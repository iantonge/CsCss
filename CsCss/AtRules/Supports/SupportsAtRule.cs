namespace CsCss.AtRules.Supports;

public sealed class SupportsAtRule
{
    private SupportsAtRule() { }

    internal static readonly SupportsAtRule Supports = new();

    public SupportsCondition Declaration(Declarations declarations) => SupportsCondition.Declaration(declarations);
}
