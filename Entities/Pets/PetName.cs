namespace Entities.Pets;

public class PetName
{
    public string Name { get; }

    private PetName(string name)
    {
        Name = name;
    }

    public static PetName Create(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException("Name cannot be null or empty");
        return new PetName(name);
    }
}