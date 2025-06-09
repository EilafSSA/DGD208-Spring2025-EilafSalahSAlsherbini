using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tomogachi_ESS_Spring2025
{
    public static class ItemDatabase
    {
        public static List<Item> AllItems = new List<Item>
        {
            



            //Foods (EACH ANIMAL SHOULD HAVE AT LEAST 3 OPTIONS TO PICK FROM AS FOOD)


            new Item {
                Name = "Kibble",
                Type = ItemType.Food,
                CompatibleWith = new List<PetType> { PetType.Dog, PetType.Cat },
                AffectedStat = PetStat.Hunger,
                EffectAmount = 15,
                Duration = 2.5f  // Takes 2.5 seconds to eat
            },
            new Item {
                Name = "Pellets",
                Type = ItemType.Food,
                CompatibleWith = new List<PetType> { PetType.Parrot, PetType.Fish },
                AffectedStat = PetStat.Hunger,
                EffectAmount = 15,
                Duration = 2.5f  // Takes 2.5 seconds to eat
            },
            new Item {
                Name = "Wet *Fishy* Food", //Specific to *cat*
                Type = ItemType.Food,
                CompatibleWith = new List<PetType> { PetType.Cat },
                AffectedStat = PetStat.Hunger,
                EffectAmount = 15,
                Duration = 2.5f  // Takes 2.5 seconds to eat
            },
            new Item {
                Name = "Bones", //Specific to *Dog* (cats can eat bones, but yk)
                Type = ItemType.Food,
                CompatibleWith = new List<PetType> { PetType.Dog },
                AffectedStat = PetStat.Hunger & PetStat.Fun,
                EffectAmount = 25,
                Duration = 5f  // Takes 5 seconds to eat
            },
            new Item {
                Name = "Fruits Slices", //Specific to *parrot*
                Type = ItemType.Food,
                CompatibleWith = new List<PetType> { PetType.Parrot },
                AffectedStat = PetStat.Hunger & PetStat.Fun,
                EffectAmount = 25,
                Duration = 5f  // Takes 5 seconds to eat
            },
            new Item {
                Name = "Algae",
                Type = ItemType.Food,
                CompatibleWith = new List<PetType> { PetType.Fish },
                AffectedStat = PetStat.Hunger,
                EffectAmount = 25,
                Duration = 1f  // Takes 2.5 seconds to eat
            },
            new Item {
                Name = "insects ",
                Type = ItemType.Food,
                CompatibleWith = new List<PetType> {  PetType.Fish, },
                AffectedStat = PetStat.Hunger,
                EffectAmount = 15,
                Duration = 1f  // Takes 1 seconds to eat
            },
            new Item {
                Name = "Egg ",
                Type = ItemType.Food,
                CompatibleWith = new List<PetType> {  PetType.Cat, PetType.Dog },
                AffectedStat = PetStat.Hunger,
                EffectAmount = 10,
                Duration = 1f  // Takes 1 seconds to eat
            },
            new Item {
                Name = "Nuts ",
                Type = ItemType.Food,
                CompatibleWith = new List<PetType> {  PetType.Parrot, },
                AffectedStat = PetStat.Hunger,
                EffectAmount = 15,
                Duration = 3f  // Takes 3 seconds to eat
            },
            





            // Universal Food
            new Item {
                Name = "Broccoli ",
                Type = ItemType.Food,
                CompatibleWith = new List<PetType> {  PetType.Fish, PetType.Parrot, PetType.Dog, PetType.Cat},
                AffectedStat = PetStat.Hunger,
                EffectAmount = 15,
                Duration = 2.5f  // Takes 2.5 seconds to eat
            },
            new Item {
                Name = "a few Cooked Shrimp ",
                Type = ItemType.Food,
                CompatibleWith = new List<PetType> {  PetType.Fish, PetType.Parrot, PetType.Dog, PetType.Cat},
                AffectedStat = PetStat.Hunger,
                EffectAmount = 10,
                Duration = 1f  // Takes 1 seconds to eat
            },
            new Item {
                Name = "Veggies ",
                Type = ItemType.Food,
                CompatibleWith = new List<PetType> {  PetType.Fish, PetType.Parrot, PetType.Dog, PetType.Cat},
                AffectedStat = PetStat.Hunger,
                EffectAmount = 25,
                Duration = 1.5f  // Takes 1 seconds to eat
            },



            // Universal Toys
            new Item {
                Name = "Ball",
                Type = ItemType.Toy,
                CompatibleWith = new List<PetType> { PetType.Dog, PetType.Cat},
                AffectedStat = PetStat.Fun,
                EffectAmount = 10,
                Duration = 2.0f
            },
            new Item {
                Name = "Feather on a Stick ",
                Type = ItemType.Toy,
                CompatibleWith = new List<PetType> { PetType.Cat },
                AffectedStat = PetStat.Fun,
                EffectAmount = 10,
                Duration = 2.0f
            },
            new Item {
                Name = "Chase with your Finger ",
                Type = ItemType.Toy,
                CompatibleWith = new List<PetType> { PetType.Fish },
                AffectedStat = PetStat.Fun,
                EffectAmount = 35,
                Duration = 6f
            },
            new Item {
                Name = "take on a Walk ",
                Type = ItemType.Toy,
                CompatibleWith = new List<PetType> { PetType.Dog, PetType.Cat },
                AffectedStat = PetStat.Fun,
                EffectAmount = 55,
                Duration = 10f
            },
            new Item {
                Name = "Teach Tricks ",
                Type = ItemType.Toy,
                CompatibleWith = new List<PetType> { PetType.Dog, PetType.Cat, PetType.Parrot, PetType.Fish },
                AffectedStat = PetStat.Fun,
                EffectAmount = 55,
                Duration = 10f
            },
            new Item {
                Name = "Let out to fly ",
                Type = ItemType.Toy,
                CompatibleWith = new List<PetType> {PetType.Parrot },
                AffectedStat = PetStat.Fun,
                EffectAmount = 55,
                Duration = 10f
            },
            
            // Sleep Items
            new Item {
                Name = "Comfy Bed",
                Type = ItemType.Bed,
                CompatibleWith = new List<PetType> { PetType.Dog, PetType.Cat },
                AffectedStat = PetStat.Sleep,
                EffectAmount = 30,
                Duration = 6.0f  // Takes time to fall asleep
            },
            new Item { 
                Name = "Pet Blanket", 
                Type = ItemType.Bed, 
                CompatibleWith = new List<PetType> { PetType.Dog, PetType.Cat }, 
                AffectedStat = PetStat.Sleep, 
                EffectAmount = 20,
                Duration = 4.0f
            },
            new Item { 
                Name = "Grassy Bed", 
                Type = ItemType.Bed, 
                CompatibleWith = new List<PetType> { PetType.Parrot, PetType.Fish }, 
                AffectedStat = PetStat.Sleep, 
                EffectAmount = 30,
                Duration = 6.0f
            },
            new Item { 
                Name = "Cozy den", 
                Type = ItemType.Bed, 
                CompatibleWith = new List<PetType> { PetType.Parrot, PetType.Fish }, 
                AffectedStat = PetStat.Sleep, 
                EffectAmount = 20,
                Duration = 4.0f
            }
    
        };
    }
}