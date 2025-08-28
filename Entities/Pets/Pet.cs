using Entities.Breeds;
using Entities.Species;

namespace Entities.Pets;

public class Pet
{
    private Pet(
        PetName name, 
        Specie specie, 
        PetDescription description, 
        Breed breed, 
        PetColor color, 
        bool vaccinated, 
        Address address, 
        PetPhysicalParameters physicals)
    {
        Name = name;
        Specie = specie;
        Description = description;
        Breed = breed;
        Color = color;
        Vaccinated = vaccinated;
        Address = address;
        Physicals = physicals;
    }
    
    /// <summary>
    /// Поменять кличку животного.
    /// </summary>
    /// <param name="newName">Новое имя</param>
    /// <exception cref="ArgumentException">Ошибка при некорректном параметре newName</exception>
    public void Rename(string newName)
    {
        Name = PetName.Create(newName);
    }
    
    /// <summary>
    /// Кличка
    /// </summary>
    public PetName Name { get; private set; }

    /// <summary>
    /// Вид животного
    /// </summary>
    public Specie Specie { get; private set; }
    
    /// <summary>
    /// Описание
    /// </summary>
    public PetDescription Description { get; private set; }
    
    /// <summary>
    /// Порода
    /// </summary>
    public Breed Breed { get; private set; }
    
    /// <summary>
    /// Окрас
    /// </summary>
    public PetColor Color { get; private set; }
    
    /// <summary>
    /// Информация о здоровье (привит или нет)
    /// </summary>
    public bool Vaccinated { get; private set; }
    
    /// <summary>
    /// Адрес
    /// </summary>
    public Address Address { get; private set; }
    
    /// <summary>
    /// Физические параметры животного
    /// </summary>
    public PetPhysicalParameters Physicals { get; private set; }
    
    /// <summary>
    /// Требуется помощь или нет
    /// </summary>
    public bool HelpRequired { get; private set; } = false;
}