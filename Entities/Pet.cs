namespace Entities;

public class Pet
{
    /// <summary>
    /// Кличка
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Вид животного
    /// </summary>
    public Specie Specie { get; set; } = new();
    
    /// <summary>
    /// Описание
    /// </summary>
    public string Description { get; set; } = string.Empty;
    
    /// <summary>
    /// Порода
    /// </summary>
    public Breed Breed { get; set; } = new();
    
    /// <summary>
    /// Окрас
    /// </summary>
    public string Color { get; set; } = string.Empty;
    
    /// <summary>
    /// Информация о здоровье (привит или нет)
    /// </summary>
    public bool Vaccinated { get; set; } = false;
    
    /// <summary>
    /// Адрес
    /// </summary>
    public string Address { get; set; } = string.Empty;
    
    /// <summary>
    /// Вес
    /// </summary>
    public double Weight { get; set; }
    
    /// <summary>
    /// Рост
    /// </summary>
    public double Height { get; set; }
    
    /// <summary>
    /// Требуется помощь или нет
    /// </summary>
    public bool HelpRequired { get; set; } = false;
}