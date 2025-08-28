namespace Entities.Species;

public class Specie
{
    public Specie(SpecieName name, SpecieBreeds breeds)
    {
        Name = name;
        Breeds = breeds;
    }
    
    /// <summary>
    /// Название вида
    /// </summary>
    public SpecieName Name { get; private set; }
    /// <summary>
    /// Породы вида
    /// </summary>
    public SpecieBreeds Breeds { get; private set; }
}