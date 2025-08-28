namespace Entities.Volunteers;

public class Requisit
{
    public string Value { get; }
    private Requisit(string value) => Value = value;

    public static Requisit Create(string value)
    {
        return string.IsNullOrWhiteSpace(value)
            ? throw new ArgumentException("Requisit value was empty")
            : new Requisit(value);
    }
}