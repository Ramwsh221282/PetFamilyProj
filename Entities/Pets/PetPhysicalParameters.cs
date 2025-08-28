namespace Entities.Pets;

public class PetPhysicalParameters
{
    public double Height { get; }
    public double Weight { get; }

    private PetPhysicalParameters(double height, double weight)
    {
        Height = height;
        Weight = weight;
    }

    public static PetPhysicalParameters Create(double height, double weight)
    {
        if (weight is <= 0 or > 200)
            throw new ArgumentException("Weight must be between 0 and 200");
        if (height is <= 0 or > 200)
            throw new ArgumentException("Height must be between 0 and 200");
        return new PetPhysicalParameters(height, weight);
    }
}