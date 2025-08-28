namespace Entities.Volunteers;

public class SocialMedia
{
    public string Source { get; }
    private SocialMedia(string source) => Source = source;

    public static SocialMedia Create(string source)
    {
        return string.IsNullOrWhiteSpace(source)
            ? throw new ArgumentException("Social media is empty")
            : new SocialMedia(source);
    }
}