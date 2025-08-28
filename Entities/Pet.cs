namespace Entities;

public class Pet
{
    private Pet(
        string name, 
        Specie specie, 
        string description, 
        Breed breed, 
        string color, 
        bool vaccinated, 
        string address, 
        double weight, 
        double height)
    {
        Name = name;
        Specie = specie;
        Description = description;
        Breed = breed;
        Color = color;
        Vaccinated = vaccinated;
        Address = address;
        Weight = weight;
        Height = height;
    }

    public static Pet Create(
        string name, 
        Specie specie, 
        string description, 
        Breed breed, 
        string color, 
        bool vaccinated, 
        string address, 
        double weight, 
        double height)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException("Name is empty");
        if (name.Length > 100)
            throw new ArgumentException("Name is too long");
        if (string.IsNullOrEmpty(description))
            throw new ArgumentException("Description is empty");
        if (string.IsNullOrWhiteSpace(color))
            throw new ArgumentException("Color is empty");
        if (string.IsNullOrWhiteSpace(address))
            throw new ArgumentException("Address is empty");
        if (weight is <= 0 or > 200)
            throw new ArgumentException("Weight must be between 0 and 200");
        if (height is <= 0 or > 200)
            throw new ArgumentException("Height must be between 0 and 200");
        return new Pet(name, specie, description, breed, color, vaccinated, address, weight, height);
    }
    
    /// <summary>
    /// Поменять кличку животного.
    /// </summary>
    /// <param name="newName">Новое имя</param>
    /// <exception cref="ArgumentException">Ошибка при некорректном параметре newName</exception>
    public void Rename(string newName)
    {
        if (string.IsNullOrEmpty(newName))
            throw new ArgumentException("Name is empty");
        if (newName.Length > 100)
            throw new ArgumentException("Name is too long");
        Name = newName;
    }
    
    /// <summary>
    /// Кличка
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Вид животного
    /// </summary>
    public Specie Specie { get; private set; }
    
    /// <summary>
    /// Описание
    /// </summary>
    public string Description { get; private set; }
    
    /// <summary>
    /// Порода
    /// </summary>
    public Breed Breed { get; private set; }
    
    /// <summary>
    /// Окрас
    /// </summary>
    public string Color { get; private set; }
    
    /// <summary>
    /// Информация о здоровье (привит или нет)
    /// </summary>
    public bool Vaccinated { get; private set; }
    
    /// <summary>
    /// Адрес
    /// </summary>
    public string Address { get; private set; }
    
    /// <summary>
    /// Вес
    /// </summary>
    public double Weight { get; private set; }
    
    /// <summary>
    /// Рост
    /// </summary>
    public double Height { get; private set; }
    
    /// <summary>
    /// Требуется помощь или нет
    /// </summary>
    public bool HelpRequired { get; private set; } = false;
}