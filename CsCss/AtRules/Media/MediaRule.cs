namespace CsCss.AtRules.Media;

internal sealed class MediaRule : CssRule
{
    private readonly MediaQuery query;
    private readonly RuleList rules;

    internal MediaRule(MediaQuery query, RuleList rules)
    {
        this.query = query;
        this.rules = rules;
    }

    internal override void WriteTo(CssWriter writer, int indentLevel)
    {
        writer.WriteIndent(indentLevel);
        writer.Write("@media ");
        writer.Write(query.ToString());
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
