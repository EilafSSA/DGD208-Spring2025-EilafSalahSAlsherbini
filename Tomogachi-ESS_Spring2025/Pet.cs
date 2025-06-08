using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tomogachi_ESS_Spring2025
{
    public class Pet
    {   
        public string Name { get; }
        public PetType Type { get; }
        private int _hunger = 50, _fun = 50, _sleep = 50;
        private bool _isAlive = true;
        private PetManager _manager;
        public Pet(string name, PetType type, PetManager manager)
        {
            Name = name;
            Type = type;
            _manager = manager;
            StartStatDecay();
        }

        
        public void ShowStatus()
        {
            Console.WriteLine($"\n--- {Name} the {Type} ---");
            Console.WriteLine($"Hunger: {_hunger}/100");
            Console.WriteLine($"Fun: {_fun}/100");
            Console.WriteLine($"Sleep: {_sleep}/100");
        }

        public bool CanUseItem(Item item) => item.CompatibleWith.Contains(Type);

        public async Task UseItemAsync(Item item)
        {
            if (!CanUseItem(item))
            {
                Console.WriteLine($"{Name} can't use {item.Name}.");
                return;
            }

            Console.WriteLine($"\nUsing {item.Name} on {Name}...");
            DisplayAsciiEvent(item);
            await Task.Delay(TimeSpan.FromSeconds(item.Duration));

            switch (item.AffectedStat)
            {
                case PetStat.Hunger: _hunger = Math.Min(100, _hunger + item.EffectAmount); break;
                case PetStat.Fun: _fun = Math.Min(100, _fun + item.EffectAmount); break;
                case PetStat.Sleep: _sleep = Math.Min(100, _sleep + item.EffectAmount); break;
            }

            Console.WriteLine($"{item.Name} used! {item.AffectedStat} increased by {item.EffectAmount}.");
        }

        private async void StartStatDecay()
        {
            _ = Task.Run(async () =>
            {
                while (_isAlive = true)
                {
                    await Task.Delay(200); // Every 5 seconds, decay stats

                    _hunger = Math.Max(0, _hunger - 1);
                    _fun = Math.Max(0, _fun - 1);
                    _sleep = Math.Max(0, _sleep - 1);

                    StatResult();
                }
            });
        }

        private void StatResult()
        {
            if (_fun == 0 || _hunger == 0 || _sleep == 0)
            {
                _isAlive = false;
                Console.WriteLine($"{Name} has died.");
                _manager.Death(this); // Remove from pet list
            }
        }



        private void DisplayAsciiEvent(Item item)
        {
            if (item.Type == ItemType.Food)
            {
                Console.WriteLine(Type switch
                {
                    PetType.Cat => "(=^･ω･^=) munching...",
                    PetType.Dog => DogFeedingAnim(),
                    _ => "*nom nom*"
                });
            }
            else if (item.Type == ItemType.Toy)
            {
                Console.WriteLine(Type switch
                {
                    PetType.Cat => "ฅ^•ﻌ•^ฅ playing!",
                    PetType.Dog => "U・ᴥ・U wagging!",
                    _ => "*having fun*"
                });
            }
        }

        public override string ToString() => $"{Name} ({Type})";

        #region Ready Animations

        static async Task DogFeedingAnim()
        {
            AsciiDataBase asciiArt = new AsciiDataBase();
            string dogHappy = asciiArt.GetAsciiArt(PetType.Dog, "Happy");
            string dogFrame1 = asciiArt.GetAsciiArt(PetType.Dog, "Inbetween");
            string dogFrame2 = asciiArt.GetAsciiArt(PetType.Dog, "FoodAnim1");
            string dogFrame3 = asciiArt.GetAsciiArt(PetType.Dog, "FoodAnim2");

            Console.Clear();
            Console.WriteLine(dogFrame1);
            Thread.Sleep(600);
            Console.Clear();
            Console.WriteLine(dogFrame2);
            Thread.Sleep(600);
            Console.Clear();
            Console.WriteLine(dogFrame3);
            Thread.Sleep(600);
            Console.Clear();
        }


        #endregion
    }
}
