namespace Entities.Volunteers;

public class WorkingExperience
{
    public int Years { get; }

    private WorkingExperience(int years)
    {
        Years = years;
    }

    public static WorkingExperience Create(int years)
    {
        if (years < 0)
            throw new ArgumentException("Years cannot be less than zero.");
        if (years > 50)
            throw new ArgumentException("Years cannot be greater than 90.");
        return new WorkingExperience(years);
    }
}