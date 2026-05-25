namespace CsCss.AtRules.Media;

public sealed class DiscreteMediaFeature
{
    private readonly string name;

    internal DiscreteMediaFeature(string name) => this.name = name;

    public MediaQuery this[string value] => new($"({name}: {value})");
}
