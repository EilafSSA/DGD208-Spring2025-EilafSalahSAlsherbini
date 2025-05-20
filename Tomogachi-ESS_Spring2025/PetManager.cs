using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}