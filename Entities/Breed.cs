namespace Entities;

public class Breed
{
    private Breed(string name)
    {
        Name = name;
    }

    public static Breed Create(string name)
    {
        return string.IsNullOrWhiteSpace(name) ? 
            throw new ArgumentException("Pet name is empty") 
            : new Breed(name);
    }
    
    /// <summary>
    /// Название породы
    /// </summary>
    public string Name { get; private set; }
}