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
        PetManager petManager = new PetManager();
        private bool _isRunning;
        private List<Pet> _pets = new();

        public async Task GameLoop()
        {
            _isRunning = true;

            while (_isRunning)
            {
                Console.Clear();
                Console.WriteLine(@"

                          ! WELCOME !
            _____ _____ _________  _____  ____  ____ 
            || T  || O |||       ||| T ||| H ||| E ||
            |/___\|/___\|/_______\|/___\|/___\|/___\|

 __ __|  _ \    \  |   _ \    ___|     \      ___|  |   | _ _| 
    |   |   |  |\/ |  |   |  |        _ \    |      |   |   |  
    |   |   |  |   |  |   |  |   |   ___ \   |      ___ |   |  
   _|  \___/  _|  _| \___/  \____| _/    _\ \____| _|  _| ___| HUB!                       
                
                
                ");
                Console.WriteLine("1. Check Pets");
                Console.WriteLine("2. Interact with a Pet");
                Console.WriteLine("3. Adopt a New Pet");
                Console.WriteLine("4. Credits!");
                Console.WriteLine("5. Exit");
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
                        Console.Clear();
                        Console.Clear();
                        Console.WriteLine(@"
                        


★ Hello!, This is Eilaf Salah S. Alsherbini, I hope my project meets you well. ★

✦ Student ID: 2305045032 ✦

Tomogachi Spring Final of 2025 in DGD208 - Game Programing 2



✦✦✦ (this is a long credit list so be sure to scroll) ✦✦✦
___________________________________________

✦ EXTRA NOTES ✦ 
> There are images of what the sprites are in the files actually in a folder called 'Original drawings of sprites'

> Inside of my Github Commits are my notes when I was programming as well as a txt file called 'Basic planning I.txt'
___________________________________________

             _    _      _       
            | |  (_)_ _ | |__ ___
            | |__| | ' \| / /(_-<
            |____|_|_||_|_\_\/__/
                    

★ All ASCII art is drawn/animated by me (in procreate), 
    => then put through [https://www.asciiart.eu/image-to-ascii] then cleaned them up throughly.

ASCII text was made through: [ patorjk.com/software/taag/#p=display&f=Graffiti&t=Type%20Something%20 ]
___________________________________________

★ The use of AI was needed (sadly) [ChatGPT]
___________________________________________

★ A lot of the microsoft guides for C# was really important for me, 
    especially when needing to remember things again.
    ^
    (In order of links- 
    Contructors, Dictionaries, classes)
    ===================================                      
    => [ https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors ]
    => [ https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-9.0 ]
    => [ https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/classes ] 
___________________________________________

★ This github repo I found, by Nilvisa in 2015, [ https://github.com/nilvisa/tamagotchi ]

    (It didn't help much for it felt important to credit cause it pushed me to want to finish this project at the start)

___________________________________________

★★★ [I hope you had a good Bayram Professor.] ★★★

______________________________________________________________________________________

                        ");
                        Console.WriteLine("\n★ Press any key to return... ★");
                        Console.ReadKey();
                        break;

                    case "5":
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
            Console.Clear();
            Console.Clear();
            Console.Clear();
            Console.Clear();
            if (_pets.Count == 0)
            {
                Console.WriteLine("You have no pets.");
            }
            else
            {
                foreach (var pet in _pets)
                {
                    Console.Clear();
                    pet.ShowStatus();
                    petManager.PetStatusASCII(pet);  // << call here for each pet
                }
            }

            Console.WriteLine("\n★ Press any key to return... ★");
            Console.ReadKey();
        }

        private async Task InteractWithPet()
        {
            if (_pets.Count == 0)
            {
                Console.WriteLine(" You have no pets to interact with. ");
                Console.WriteLine("");
                Console.ReadKey();
                return;
            }


            var petMenu = new Menu<Pet>(" Select a Pet ", _pets, p => p.Name);
            var selectedPet = petMenu.ShowAndGetSelection();
            if (selectedPet == null) return;


            var compatibleItems = ItemDatabase.AllItems
                .Where(item => item.CompatibleWith.Contains(selectedPet.Type))
                .ToList();


            var foodItems = compatibleItems.Where(i => i.Type == ItemType.Food).ToList();
            var toyItems = compatibleItems.Where(i => i.Type == ItemType.Toy).ToList();
            var bedItems = compatibleItems.Where(i => i.Type == ItemType.Bed).ToList();


            var categoryMenu = new Menu<string>(" Select Item Category ", new List<string> { "Food", "Toy", "Bed" }, s => s);
            var selectedCategory = categoryMenu.ShowAndGetSelection();
            if (selectedCategory == null) return;


            List<Item> categoryItems = selectedCategory switch
            {   "Food" => foodItems,
                "Toy" => toyItems,
                "Bed" => bedItems,
                _ => new List<Item>() };


            if (categoryItems.Count == 0)
            {
                Console.WriteLine($"No {selectedCategory} items available for this pet.");
                Console.ReadKey();
                return;
            }

            var itemMenu = new Menu<Item>($" Select {selectedCategory} Item ", categoryItems, i => i.Name);
            var selectedItem = itemMenu.ShowAndGetSelection();
            if (selectedItem == null) return;

            await selectedPet.UseItemAsync(selectedItem);

            Console.WriteLine();
            Console.WriteLine("\n★ Press any key to return... ★");
            Console.ReadKey();
        }

        private Pet CreatePet()
        {
            Console.Clear();
            Console.Write(" Enter a name for your new pet:  ");
            string name = Console.ReadLine();

            var types = Enum.GetValues(typeof(PetType)).Cast<PetType>().ToList();
            var typeMenu = new Menu<PetType>("Select Pet Type", types, t => t.ToString());
            PetType selectedType = typeMenu.ShowAndGetSelection();

            if (selectedType == default) return null;

            return new Pet(name, selectedType, petManager);
        }
    

    }

 }


