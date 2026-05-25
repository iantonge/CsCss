namespace CsCss.AtRules.Media;

public sealed class MediaAtRule
{
    private MediaAtRule() { }

    internal static readonly MediaAtRule Media = new();

    public MediaFeature Width { get; } = new("width");
}
