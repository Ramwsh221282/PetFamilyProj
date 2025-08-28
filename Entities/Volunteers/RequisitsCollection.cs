namespace Entities.Volunteers;

public class RequisitsCollection
{
    private const int MaxLength = 5;
    private readonly List<Requisit> _requisits;
    public void Add(Requisit requisit)
    {
        if (_requisits.Count == MaxLength)
            throw new ArgumentException("Requisits cannot be exceed the length of 5.");
        if (_requisits.Any(r => r == requisit))
            throw new ArgumentException($"Requisit {requisit} already exists");
        _requisits.Add(requisit);
    }
    
    private RequisitsCollection(IEnumerable<Requisit> requisits) =>
        _requisits = new List<Requisit>(requisits);
    
    public Requisit Find(string requisit)
    {
        Requisit? existing = _requisits.FirstOrDefault(r => r.Value == requisit);
        return existing ?? throw new InvalidOperationException("Requisit is not found.");
    }

    public void Remove(Requisit requisit)
    {
        Requisit existing = Find(requisit.Value);
        _requisits.Remove(existing);
    }
    public IEnumerable<Requisit> Iterate() => _requisits;

    public static RequisitsCollection Create() => new([]);

    public static RequisitsCollection Create(IEnumerable<Requisit> requisits)
    {
        Requisit[] array = requisits.ToArray();
        if (array.Length == MaxLength)
            throw new ArgumentException("Requisits cannot be exceed the length of 5.");
        return array.Select(r => r.Value).Distinct().Count() > 1 ? 
            throw new ArgumentException($"Requisit must be unique exists") 
            : new RequisitsCollection(array);
    }
}