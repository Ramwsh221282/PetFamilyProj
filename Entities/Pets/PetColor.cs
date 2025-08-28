namespace Entities.Pets;

public class PetColor
{
    public string Value { get; }

    private PetColor(string value)
    {
        Value = value;
    }

    public static PetColor Create(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentException("Color cannot be null or empty");
        return new PetColor(value);
    }
}