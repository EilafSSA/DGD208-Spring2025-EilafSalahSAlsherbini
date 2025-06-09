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
                    Console.WriteLine("No pet provided.");
                    return;
                }

                AsciiDataBase ascii = new AsciiDataBase();

                if (pet.IsFull || pet.IsHappy || pet.IsEnergized) //HAPPY!
                {
                    Console.WriteLine($"{pet.Name} is very Happy!");
                    Console.WriteLine(pet.Type switch
                    {
                        PetType.Cat => ascii.GetAsciiArt(PetType.Cat, "Happy"),
                        PetType.Dog => ascii.GetAsciiArt(PetType.Dog, "Happy"),
                        PetType.Fish => ascii.GetAsciiArt(PetType.Fish, "Happy"),
                        PetType.Parrot => ascii.GetAsciiArt(PetType.Parrot, "Happy"),
                        _ => "*You hear your pet call out to you with eagerness*"
                    });
                }
                else if (pet.IsFeed || pet.IsOkay || pet.IsFine) //NEUTRAL
                {
                    Console.WriteLine($"{pet.Name} is Fine");
                    Console.WriteLine(pet.Type switch
                    {
                        PetType.Cat => ascii.GetAsciiArt(PetType.Cat, "Neutral"),
                        PetType.Dog => ascii.GetAsciiArt(PetType.Dog, "Neutral"),
                        PetType.Fish => ascii.GetAsciiArt(PetType.Fish, "Neutral"),
                        PetType.Parrot => ascii.GetAsciiArt(PetType.Parrot, "Neutral"),
                        _ => "*You hear your pet call out to you with eagerness*"
                    });
                }
                else if (pet.IsHungry || pet.IsSad || pet.IsTired) //ANGRY
                {
                    Console.WriteLine($"{pet.Name} Needs attention!");
                    Console.WriteLine(pet.Type switch
                    {
                        PetType.Cat => ascii.GetAsciiArt(PetType.Cat, "Angry"),
                        PetType.Dog => ascii.GetAsciiArt(PetType.Dog, "Angry"),
                        PetType.Fish => ascii.GetAsciiArt(PetType.Fish, "Angry"),
                        PetType.Parrot => ascii.GetAsciiArt(PetType.Parrot, "Angry"),
                        _ => "*You hear them call out to you with annoyance...*"
                    });
                }
                else if (pet.IsStarving || pet.IsDepressed || pet.IsExhausted) //SAD
                {
                    Console.WriteLine($"{pet.Name} needs to be cared for!");
                    Console.WriteLine(pet.Type switch
                    {
                        PetType.Cat => ascii.GetAsciiArt(PetType.Cat, "Sad"),
                        PetType.Dog => ascii.GetAsciiArt(PetType.Dog, "Sad"),
                        PetType.Fish => ascii.GetAsciiArt(PetType.Fish, "Sad"),
                        PetType.Parrot => ascii.GetAsciiArt(PetType.Parrot, "Sad"),
                        _ => "*...*"
                    });
                }
                else
                {
                    Console.WriteLine($"{pet.Name}'s face is blank. You cannot tell their emotions- at all. (somehow)");
                }
            }
    }
}