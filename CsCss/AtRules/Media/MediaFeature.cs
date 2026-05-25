using CsCss.Values.Length;

namespace CsCss.AtRules.Media;

public sealed class MediaFeature
{
    private readonly string name;

    internal MediaFeature(string name) => this.name = name;

    public static MediaQuery operator >=(MediaFeature feature, LengthValue value) => new($"({feature.name} >= {value})");

    public static MediaQuery operator <=(MediaFeature feature, LengthValue value) => new($"({feature.name} <= {value})");

    public static MediaQuery operator >(MediaFeature feature, LengthValue value) => new($"({feature.name} > {value})");

    public static MediaQuery operator <(MediaFeature feature, LengthValue value) => new($"({feature.name} < {value})");
}
