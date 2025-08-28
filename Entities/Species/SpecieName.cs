namespace Entities.Species;

public class SpecieName
{
    public string Name { get; }

    private SpecieName(string name)
    {
        Name = name;
    }

    public static SpecieName Create(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException("Name cannot be null or empty");
        return new SpecieName(name);
    }
}