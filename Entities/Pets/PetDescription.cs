namespace Entities.Pets;

public class PetDescription
{
    public string Description { get; }

    private PetDescription(string description)
    {
        Description = description;
    }

    public static PetDescription Create(string description)
    {
        if (string.IsNullOrEmpty(description))
            throw new ArgumentException("Description cannot be null or empty");
        return new PetDescription(description);
    }
}