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
            //Foods
            new Item {
                Name = "Kibble",
                Type = ItemType.Food,
                CompatibleWith = new List<PetType> { PetType.Dog, PetType.Cat },
                AffectedStat = PetStat.Hunger,
                EffectAmount = 15,
                Duration = 2.5f  // Takes 2.5 seconds to eat
            },
            new Item {
                Name = "Seeds",
                Type = ItemType.Food,
                CompatibleWith = new List<PetType> { PetType.Parrot, PetType.Parrot },
                AffectedStat = PetStat.Hunger,
                EffectAmount = 15,
                Duration = 2.5f  // Takes 2.5 seconds to eat
            },
            new Item {
                Name = "Wet *Fishy* Food",
                Type = ItemType.Food,
                CompatibleWith = new List<PetType> { PetType.Cat },
                AffectedStat = PetStat.Hunger,
                EffectAmount = 15,
                Duration = 2.5f  // Takes 2.5 seconds to eat
            },
            new Item {
                Name = "Lettuce",
                Type = ItemType.Food,
                CompatibleWith = new List<PetType> { PetType.Rabbit, PetType.Fish, PetType.Parrot },
                AffectedStat = PetStat.Hunger,
                EffectAmount = 15,
                Duration = 2.5f  // Takes 2.5 seconds to eat
            },
            // Universal Toys
            new Item {
                Name = "Ball",
                Type = ItemType.Toy,
                CompatibleWith = new List<PetType> { PetType.Dog, PetType.Cat, PetType.Rabbit },
                AffectedStat = PetStat.Fun,
                EffectAmount = 10,
                Duration = 2.0f
            },
            
            // Sleep Items
            new Item { 
                Name = "Comfy Bed", 
                Type = ItemType.Toy, 
                CompatibleWith = new List<PetType> { PetType.Dog, PetType.Cat }, 
                AffectedStat = PetStat.Sleep, 
                EffectAmount = 30,
                Duration = 6.0f  // Takes time to fall asleep
            },
            new Item { 
                Name = "Pet Blanket", 
                Type = ItemType.Toy, 
                CompatibleWith = new List<PetType> { PetType.Dog, PetType.Cat, PetType.Rabbit }, 
                AffectedStat = PetStat.Sleep, 
                EffectAmount = 20,
                Duration = 4.0f
            }
    
        };
    }
}