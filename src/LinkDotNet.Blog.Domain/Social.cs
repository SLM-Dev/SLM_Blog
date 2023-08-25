namespace LinkDotNet.Blog.Domain;

public sealed record Social
{
    public string LinkedinAccountUrl { get; init; }

    public bool HasLinkedinAccount => !string.IsNullOrEmpty(LinkedinAccountUrl);

    public string GithubAccountUrl { get; init; }

    public bool HasGithubAccount => !string.IsNullOrEmpty(GithubAccountUrl);

    public string TwitterAccountUrl { get; init; }

    public bool HasTwitterAccount => !string.IsNullOrEmpty(TwitterAccountUrl);

    public string YoutubeAccountUrl { get; init; }

    public bool HasYoutubeAccount => !string.IsNullOrEmpty(YoutubeAccountUrl);

    
}