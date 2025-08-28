namespace Entities;

public class Volunteer
{
    private Volunteer(
        string firstName,
        string surname,
        string thirdName,
        string contacts,
        int experienceInYears,
        int helpedPets,
        int petsRequiringHelp,
        IEnumerable<string> requisits,
        IEnumerable<string> socialMedia,
        IEnumerable<Pet> pets)
    {
        FirstName = firstName;
        Surname = surname;
        ThirdName = thirdName;
        Contacts = contacts;
        ExperienceInYears = experienceInYears;
        HelpedPets = helpedPets;
        PetsRequiringHelp = petsRequiringHelp;
        Requisits = requisits.ToList();
        SocialMedia = socialMedia.ToList();
        Pets = pets.ToList();
    }

    public static Volunteer Create(
        string firstName,
        string surname,
        string thirdName,
        string contacts,
        int experienceInYears,
        int helpedPets,
        int petsRequiringHelp,
        IEnumerable<string> requisits,
        IEnumerable<string> socialMedia,
        IEnumerable<Pet> pets)
    {
        if (string.IsNullOrWhiteSpace(firstName))
            throw new ArgumentException("First name cannot be null or whitespace.");
        if (string.IsNullOrWhiteSpace(surname))
            throw new ArgumentException("Surname cannot be null or whitespace.");
        if (string.IsNullOrWhiteSpace(thirdName))
            throw new ArgumentException("Third name cannot be null or whitespace.");
        if (string.IsNullOrWhiteSpace(contacts))
            throw new ArgumentException("Contacts cannot be null or whitespace.");
        if (experienceInYears < 0)
            throw new ArgumentException("ExperienceInYears cannot be negative.");
        if (helpedPets < 0)
            throw new ArgumentException("HelpedPets cannot be negative.");
        if (petsRequiringHelp < 0)
            throw new ArgumentException("PetsRequiringHelp cannot be negative.");
        if (requisits.Any(r => string.IsNullOrWhiteSpace(r)))
            throw new ArgumentException("Requisits cannot be null or whitespace.");
        if (socialMedia.Any(s => string.IsNullOrWhiteSpace(s)))
            throw new ArgumentException("SocialMedia cannot be null or whitespace.");
        return new Volunteer(firstName, surname, thirdName, contacts, experienceInYears, helpedPets, petsRequiringHelp, requisits, socialMedia, pets);
    }
    
    /// <summary>
    /// Имя
    /// </summary>
    public string FirstName { get; private set; }
    /// <summary>
    /// Фамилия
    /// </summary>
    public string Surname { get; private set; }
    /// <summary>
    /// Отчество
    /// </summary>
    public string ThirdName { get; private set; }
    /// <summary>
    /// Контакты
    /// </summary>
    public string Contacts { get; private set; }
    /// <summary>
    /// Опыт в годах
    /// </summary>
    public int ExperienceInYears { get; private set; }
    /// <summary>
    /// Животные, которые смогли найти дом
    /// </summary>
    public int HelpedPets { get; private set; }
    /// <summary>
    /// Животные, требующие помощи в данный момент
    /// </summary>
    public int PetsRequiringHelp { get; private set; }
    /// <summary>
    /// Реквизиты
    /// </summary>
    public List<string> Requisits { get; private set; }
    /// <summary>
    /// Список соц. медии Волонтера
    /// </summary>
    public List<string> SocialMedia { get; private set; }
    /// <summary>
    /// Записи животных
    /// </summary>
    public List<Pet> Pets { get; private set; }
}