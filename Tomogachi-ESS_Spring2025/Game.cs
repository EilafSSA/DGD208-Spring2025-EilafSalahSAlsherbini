using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomogachi_ESS_Spring2025
{
    public class Game
    {
        AsciiDataBase asciiArt = new AsciiDataBase();
        private bool _isRunning;
        private List<Pet> _pets = new();

        public async Task GameLoop()
        {
            _isRunning = true;

            while (_isRunning)
            {
                Console.Clear();
                Console.WriteLine("=== Pet Home ===\n");
                Console.WriteLine("1. Check Pets");
                Console.WriteLine("2. Interact with a Pet");
                Console.WriteLine("3. Adopt a New Pet");
                Console.WriteLine("4. Exit");
                Console.Write("\nChoose an option: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CheckPets();
                        break;
                    case "2":
                        await InteractWithPet();
                        break;
                    case "3":
                        if (_pets.Count >= 3)
                        {
                            Console.WriteLine("You can't adopt more than 3 pets.");
                            Console.ReadKey();
                        }
                        else
                        {
                            var newPet = CreatePet();
                            if (newPet != null) _pets.Add(newPet);
                        }
                        break;
                    case "4":
                        _isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        Console.ReadKey();
                        break;
                }
            }

            Console.WriteLine("Thanks for playing!");
        }

        private void CheckPets()
        {
            Console.Clear();
            if (_pets.Count == 0)
            {
                Console.WriteLine("You have no pets.");
            }
            else
            {
                foreach (var pet in _pets)
                    pet.ShowStatus();
            }
            Console.WriteLine("\nPress any key to return...");
            Console.ReadKey();
        }

        private async Task InteractWithPet()
        {
            if (_pets.Count == 0)
            {
                Console.WriteLine("You have no pets to interact with.");
                Console.WriteLine("");
                Console.ReadKey();
                return;
            }

            var petMenu = new Menu<Pet>("Select a Pet", _pets, p => p.Name);
            var selectedPet = petMenu.ShowAndGetSelection();
            if (selectedPet == null) return;

            var compatibleItems = ItemDatabase.AllItems
                .Where(item => item.CompatibleWith.Contains(selectedPet.Type))
                .ToList();

            var itemMenu = new Menu<Item>("Select Item", compatibleItems, i => i.Name);
            var selectedItem = itemMenu.ShowAndGetSelection();
            if (selectedItem == null) return;

            await selectedPet.UseItemAsync(selectedItem);
            Console.WriteLine();
            Console.WriteLine("\nPress any key to return...");
            Console.ReadKey();

            //---------------------------------(selected pet is limited to here, so I gotta place my animation methods in this method)----

            #region ANIMATIONS

            string mood = "Happy";
            string art = asciiArt.GetAsciiArt(selectedPet.Type, mood);
            Console.WriteLine(art);

            string PetInbetween = asciiArt.GetAsciiArt(selectedPet.Type, "Inbetween");
            string PetFoodAnim1 = asciiArt.GetAsciiArt(selectedPet.Type, "FoodAnim1");
            string PetFoodAnim2 = asciiArt.GetAsciiArt(selectedPet.Type, "FoodAnim2");

            Console.WriteLine(PetFoodAnim1);

            #endregion
        }

        

        private Pet CreatePet()
        {
            Console.Clear();
            Console.Write("Enter a name for your new pet: ");
            string name = Console.ReadLine();

            var types = Enum.GetValues(typeof(PetType)).Cast<PetType>().ToList();
            var typeMenu = new Menu<PetType>("Select Pet Type", types, t => t.ToString());
            PetType selectedType = typeMenu.ShowAndGetSelection();

            if (selectedType == default) return null;

            PetManager petManager = new PetManager();
            return new Pet(name, selectedType, petManager);
        }
    

    }

 }


