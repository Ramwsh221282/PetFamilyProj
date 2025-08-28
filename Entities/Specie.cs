namespace Entities;

public class Specie
{
    private Specie(string name, IEnumerable<Breed> breeds)
    {
        Name = name;
        Breeds = breeds.ToList();
    }

    public static Specie Create(string name, IEnumerable<Breed> breeds)
    {
        return string.IsNullOrEmpty(name) ?
            throw new ArgumentException("Specie name is empty.") 
            : new Specie(name, breeds);
    }

    public static Specie Create(string name)
    {
        return Create(name, []);
    }
    
    /// <summary>
    /// Название вида
    /// </summary>
    public string Name { get; private set; }
    /// <summary>
    /// Породы вида
    /// </summary>
    public List<Breed> Breeds { get; private set; }
}