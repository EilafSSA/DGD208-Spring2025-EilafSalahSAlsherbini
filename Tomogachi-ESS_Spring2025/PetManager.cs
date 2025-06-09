using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Tomogachi_ESS_Spring2025
{
    public class PetManager
    {
        private readonly List<Pet> _pets = new();

        public void AddPet(Pet pet)
        {
            _pets.Add(pet);
        }

        public List<Pet> GetAllPets()
        {
            return _pets;
        }

        public Pet GetPetByName(string name)
        {
            return _pets.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
        public void Death(Pet pet)
        {
            _pets.Remove(pet);
        }

        public void PetStatusASCII(Pet pet)
        {
            if (pet == null)
            {
                Console.WriteLine("★✩★ No pet provided. ★✩★");
                return;
            }

            AsciiDataBase ascii = new AsciiDataBase();

            var mood = pet.GetMood();
            Console.WriteLine($"★✩★ {pet.Name} is feeling {mood}! ★✩★");

            string art = mood switch
            {
                PetMood.Happy => ascii.GetAsciiArt(pet.Type, "Happy"),
                PetMood.Neutral => ascii.GetAsciiArt(pet.Type, "Neutral"),
                PetMood.Angry => ascii.GetAsciiArt(pet.Type, "Angry"),
                PetMood.Sad => ascii.GetAsciiArt(pet.Type, "Sad"),
                _ => "*...*"
            };

            Console.WriteLine(art);
        }
    }
}