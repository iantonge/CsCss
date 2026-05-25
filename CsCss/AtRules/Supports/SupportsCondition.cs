namespace CsCss.AtRules.Supports;

public sealed class SupportsCondition
{
    private readonly string condition;

    private SupportsCondition(string condition) => this.condition = condition;

    internal static SupportsCondition Declaration(Declarations declarations)
    {
        if (declarations.Items.Count != 1)
        {
            throw new ArgumentException("Supports declaration conditions require exactly one declaration.", nameof(declarations));
        }

        var declaration = declarations.Items[0];
        return new($"({declaration.property}: {declaration.value})");
    }

    public static SupportsCondition operator !(SupportsCondition condition) => new($"not {condition}");

    public static SupportsCondition operator &(SupportsCondition left, SupportsCondition right) => new($"{left} and {right}");

    public static SupportsCondition operator |(SupportsCondition left, SupportsCondition right) => new($"{left} or {right}");

    public override string ToString() => condition;
}
