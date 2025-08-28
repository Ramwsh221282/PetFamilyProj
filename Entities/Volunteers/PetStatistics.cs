namespace Entities.Volunteers;

public class PetStatistics
{
    public int HelpedAmount { get; }
    public int RequiringHelp { get; }

    private PetStatistics(int helpedAmount, int requiringHelp)
    {
        HelpedAmount = helpedAmount;
        RequiringHelp = requiringHelp;
    }

    public static PetStatistics Create(int helpedAmount, int requiringHelp)
    {
        if (helpedAmount < 0)
            throw new ArgumentException("Helped amount cannot be less than zero.");
        if (requiringHelp < 0)
            throw new ArgumentException("Requiring help cannot be less than zero.");
        return new PetStatistics(helpedAmount, requiringHelp);
    }
}