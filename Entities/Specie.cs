namespace Entities;

public class Specie
{
    /// <summary>
    /// Название вида
    /// </summary>
    public string Name { get; set; } = string.Empty;
    /// <summary>
    /// Породы вида
    /// </summary>
    public List<Breed> Breeds { get; set; } = [];
}