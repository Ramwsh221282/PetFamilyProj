namespace Entities.Breeds;

public class Breed
{
    public Breed(BreedName name)
    {
        Name = name;
    }
    
    /// <summary>
    /// Название породы
    /// </summary>
    public BreedName Name { get; private set; }
}