namespace Entities.Volunteers;

public class Volunteer
{
    private readonly RequisitsCollection _requisits;
    private readonly SocialMediaCollection _socialMedia;
    private readonly VolunteerPets _pets;
    
    private Volunteer(
        Name name,
        Contacts contacts,
        WorkingExperience experience,
        PetStatistics petStats,
        RequisitsCollection requisits,
        SocialMediaCollection socialMedia,
        VolunteerPets pets)
    {
        Name = name;
        Contacts = contacts;
        Experience = experience;
        Statistics = petStats;
        _requisits = requisits;
        _socialMedia = socialMedia;
        _pets = pets;
    }
    
    /// <summary>
    /// Имя волонтера
    /// </summary>
    public Name Name { get; }
    /// <summary>
    /// Контакты
    /// </summary>
    public Contacts Contacts { get; private set; }
    /// <summary>
    /// Опыт в годах
    /// </summary>
    public WorkingExperience Experience { get; private set; }
    /// <summary>
    /// Статистика помощи животным
    /// </summary>
    public PetStatistics Statistics { get; }

    /// <summary>
    /// Добавление реквизита
    /// </summary>
    /// <param name="requisit">Реквизит</param>
    public void AddRequisit(Requisit requisit) => _requisits.Add(requisit);

    /// <summary>
    /// Удаление реквизита
    /// </summary>
    /// <param name="requisit">Реквизит</param>
    public void RemoveRequisit(Requisit requisit) => _requisits.Remove(requisit);
    
    /// <summary>
    /// Получить все реквизиты
    /// </summary>
    /// <returns>Список реквизитов</returns>
    public IEnumerable<Requisit> IterateRequisits() => _requisits.Iterate();
    
    /// <summary>
    /// Найти реквизит
    /// </summary>
    /// <param name="requisit">Реквизит, который нужно найти</param>
    /// <returns>Найденный реквизит</returns>
    /// <exception cref="InvalidOperationException">Если реквизит не найден - исключение</exception>
    public Requisit FindRequisit(string requisit) => _requisits.Find(requisit);
}