namespace Entities.Pets;

public class Address
{
    public string City { get; }

    private Address(string city)
    {
        City = city;
    }

    public static Address Create(string city)
    {
        if (string.IsNullOrEmpty(city))
            throw new ArgumentException("City cannot be null or empty");
        return new Address(city);
    }
}