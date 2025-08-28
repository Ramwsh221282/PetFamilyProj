namespace Entities.Volunteers;

public class Contacts
{
    public string Value { get; }

    private Contacts(string value) => Value = value;

    public static Contacts Create(string value)
    {
        return string.IsNullOrWhiteSpace(value)
            ? throw new ArgumentException("Contacts value are empty.")
            : new Contacts(value);
    }
}