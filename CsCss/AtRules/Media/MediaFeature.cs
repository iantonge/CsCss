namespace CsCss.AtRules.Media;

public abstract class MediaFeature
{
    private readonly string name;

    protected MediaFeature(string name) => this.name = name;

    public string Name => name;

    public static implicit operator MediaQuery(MediaFeature feature) => new($"({feature.Name})");
}
