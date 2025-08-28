namespace Entities.Breeds;

public class BreedName
{
    public string Name { get; }

    private BreedName(string name)
    {
        Name = name;
    }

    public static BreedName Create(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException("Name cannot be null or empty");
        return new BreedName(name);
    }
}