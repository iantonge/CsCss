namespace CsCss.AtRules.Supports;

public sealed class SupportsCondition
{
    private readonly Kind kind;
    private readonly string? declaration;
    private readonly SupportsCondition? left;
    private readonly SupportsCondition? right;

    private SupportsCondition(string declaration)
    {
        kind = Kind.Declaration;
        this.declaration = declaration;
    }

    private SupportsCondition(Kind kind, SupportsCondition left)
    {
        this.kind = kind;
        this.left = left;
    }

    private SupportsCondition(Kind kind, SupportsCondition left, SupportsCondition right)
    {
        this.kind = kind;
        this.left = left;
        this.right = right;
    }

    internal static SupportsCondition Declaration(Declarations declarations)
    {
        if (declarations.Items.Count != 1)
        {
            throw new ArgumentException("Supports declaration conditions require exactly one declaration.", nameof(declarations));
        }

        var declaration = declarations.Items[0];
        return new($"({declaration.property}: {declaration.value})");
    }

    internal SupportsCondition Group() => new(Kind.Group, this);

    public static SupportsCondition operator !(SupportsCondition condition) => new(Kind.Not, condition);

    public static SupportsCondition operator &(SupportsCondition left, SupportsCondition right) => new(Kind.And, left, right);

    public static SupportsCondition operator |(SupportsCondition left, SupportsCondition right) => new(Kind.Or, left, right);

    public override string ToString() => Render(parent: null);

    private string Render(Kind? parent)
    {
        var rendered = kind switch
        {
            Kind.Declaration => declaration!,
            Kind.Not => $"not {left!.Render(kind)}",
            Kind.And => $"{left!.Render(kind)} and {right!.Render(kind)}",
            Kind.Or => $"{left!.Render(kind)} or {right!.Render(kind)}",
            Kind.Group => $"({left!.Render(parent: null)})",
            _ => throw new InvalidOperationException("Unknown supports condition kind.")
        };

        return NeedsParentheses(parent) ? $"({rendered})" : rendered;
    }

    private bool NeedsParentheses(Kind? parent)
    {
        if (parent is null || kind is Kind.Declaration or Kind.Group)
        {
            return false;
        }

        if (parent is Kind.Not)
        {
            return kind is Kind.And or Kind.Or;
        }

        return (parent is Kind.And or Kind.Or) && kind != parent;
    }

    private enum Kind
    {
        Declaration,
        Not,
        And,
        Or,
        Group
    }
}
