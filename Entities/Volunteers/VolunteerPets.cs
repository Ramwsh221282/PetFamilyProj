using Entities.Pets;

namespace Entities.Volunteers;

public class VolunteerPets
{
    private readonly List<Pet> _pets;
    private VolunteerPets(IEnumerable<Pet> pets) => _pets = pets.ToList();
    public void Add(Pet pet) => _pets.Add(pet);

    public void Remove(Pet pet)
    {
        Pet existing = ByName(pet.Name.Name);
        _pets.Remove(existing);
    }

    public Pet ByName(string name)
    {
        Pet? pet =  _pets.FirstOrDefault(p => p.Name.Name == name);
        return pet ??  throw new InvalidOperationException("Pet is not found.");
    }
    
    public IEnumerable<Pet> Iterate() => _pets;

    public static VolunteerPets Create(IEnumerable<Pet> pets)
    {
        return new VolunteerPets(pets);
    }

    public static VolunteerPets Create()
    {
        return new VolunteerPets([]);
    }
}