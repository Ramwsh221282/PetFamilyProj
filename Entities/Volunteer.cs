namespace Entities;

public class Volunteer
{
    /// <summary>
    /// Имя
    /// </summary>
    public string FirstName { get; set; } = string.Empty;
    /// <summary>
    /// Фамилия
    /// </summary>
    public string Surname { get; set; } = string.Empty;
    /// <summary>
    /// Отчество
    /// </summary>
    public string ThirdName { get; set; } = string.Empty;
    /// <summary>
    /// Контакты
    /// </summary>
    public string Contacts { get; set; } = string.Empty;
    /// <summary>
    /// Опыт в годах
    /// </summary>
    public int ExperienceInYears { get; set; } = 0;
    /// <summary>
    /// Животные, которые смогли найти дом
    /// </summary>
    public int HelpedPets { get; set; } = 0;
    /// <summary>
    /// Животные, требующие помощи в данный момент
    /// </summary>
    public int PetsRequiringHelp { get; set; } = 0;
    /// <summary>
    /// Реквизиты
    /// </summary>
    public List<string> Requisits { get; set; } = [];
    /// <summary>
    /// Список соц. медии Волонтера
    /// </summary>
    public List<string> SocialMedia { get; set; } = [];
    /// <summary>
    /// Записи животных
    /// </summary>
    public List<Pet> Pets { get; set; } = [];
}