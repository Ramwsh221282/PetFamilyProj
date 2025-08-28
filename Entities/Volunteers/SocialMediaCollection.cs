namespace Entities.Volunteers;

public class SocialMediaCollection
{
    private readonly List<SocialMedia> _socialMedias;
    private SocialMediaCollection(IEnumerable<SocialMedia> socialMedias) => _socialMedias = socialMedias.ToList();
    public void Add(SocialMedia socialMedia) => _socialMedias.Add(socialMedia);
    public IEnumerable<SocialMedia> Iterate() => _socialMedias;
    public void Remove(SocialMedia socialMedia) => _socialMedias.Remove(socialMedia);
    public SocialMedia Find(string source)
    {
        SocialMedia? media = _socialMedias.FirstOrDefault(m => m.Source == source);
        return media ?? throw new InvalidOperationException("Social media is not found.");
    }

    public static SocialMediaCollection Create(IEnumerable<SocialMedia> socialMedias) => new(socialMedias);
    public static SocialMediaCollection Create() => new([]);
}