namespace Entities.Volunteers;

public class Name
{
    public string FirstName { get; }
    public string LastName { get; }
    public string ThirdName { get; }

    private Name(string firstName, string lastName, string thirdName)
    {
        FirstName = firstName;
        LastName = lastName;
        ThirdName = thirdName;
    }

    public static Name Create(string firstName, string lastName, string thirdName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
            throw new ArgumentException("Name is empty");
        if (string.IsNullOrWhiteSpace(lastName))
            throw new ArgumentException("Name is empty");
        if (string.IsNullOrWhiteSpace(thirdName))
            throw new ArgumentException("Name is empty");
        return new Name(firstName, lastName, thirdName);
    }
}