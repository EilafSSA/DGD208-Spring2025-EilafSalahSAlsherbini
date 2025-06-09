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
        private int _hunger = 75, _fun = 75, _sleep = 75;
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
            
            Console.Clear();
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
                    await Task.Delay(5000); // 5 seconds

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
                return;
            }
        }

        //-----------------------------------------------------------------------------------------------
        private void DisplayAsciiEvent(Item item)
        {
            Animations anim = new Animations();
            
            
            if (item.Type == ItemType.Food)
            {
                Console.WriteLine(Type switch
                {
                    PetType.Cat => anim.CatFeedingAnim(),
                    PetType.Dog => anim.DogFeedingAnim(),
                    PetType.Fish => anim.FishFeedingAnim(),
                    PetType.Parrot => anim.ParrotFeedingAnim(),
                    _ => "*nom nom*"
                });
            }


            if (item.Type == ItemType.Toy)
            {
                Console.WriteLine(Type switch
                {
                    PetType.Cat => anim.CatPlay(),
                    PetType.Dog => anim.DogPlay(),
                    PetType.Fish => anim.FishPlay(),
                    PetType.Parrot => anim.ParrotPlay(),
                    _ => "*Fun! Fun!*"
                });
            }


            else if (item.Type == ItemType.Bed)
            {
                Console.WriteLine(Type switch
                {
                    PetType.Cat => anim.CatSleep(),
                    PetType.Dog => anim.DogSleep(),
                    PetType.Fish => anim.FishSleep(),
                    PetType.Parrot => anim.ParrotSleep(),
                    _ => "*Zzzzz....*"
                });
            }
        }

        public override string ToString() => $"{Name} ({Type})";
    }
}
