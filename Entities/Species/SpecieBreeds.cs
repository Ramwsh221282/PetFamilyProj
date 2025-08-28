using Entities.Breeds;

namespace Entities.Species;

public class SpecieBreeds
{
    private readonly List<Breed> _breeds;

    private SpecieBreeds(IEnumerable<Breed> breeds)
    {
        _breeds = breeds.ToList();
    }

    public static SpecieBreeds Create(IEnumerable<Breed> breeds)
    {
        if (breeds.Select(b => b.Name).Distinct().Count() > 1)
            throw new ArgumentException("Specie breeds collection must contains unique breeds");
        return new SpecieBreeds(breeds);
    }

    public static SpecieBreeds Create()
    {
        return new SpecieBreeds([]);
    }
}