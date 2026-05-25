namespace CsCss.AtRules.Supports;

internal sealed class SupportsRule : CssRule
{
    private readonly SupportsCondition condition;
    private readonly RuleList rules;

    internal SupportsRule(SupportsCondition condition, RuleList rules)
    {
        this.condition = condition;
        this.rules = rules;
    }

    internal override void WriteTo(CssWriter writer, int indentLevel)
    {
        writer.WriteIndent(indentLevel);
        writer.Write("@supports ");
        writer.Write(condition.ToString());
        writer.WriteSpace();
        writer.Write('{');
        if (rules.Rules.Count > 0)
        {
            writer.WriteLine();
            rules.WriteTo(writer, indentLevel + 1);
        }
        writer.WriteLine();
        writer.WriteIndent(indentLevel);
        writer.Write('}');
    }
}
