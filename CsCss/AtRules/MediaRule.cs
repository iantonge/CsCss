using System.Text;

namespace CsCss.AtRules;

internal sealed class MediaRule : CssRule
{
    private readonly MediaQuery query;
    private readonly RuleList rules;

    internal MediaRule(MediaQuery query, RuleList rules)
    {
        this.query = query;
        this.rules = rules;
    }

    internal override void AppendTo(StringBuilder sb, int indentLevel)
    {
        sb.Append(Indent(indentLevel));
        sb.Append("@media ");
        sb.Append(query);
        sb.Append(" {");
        rules.AppendTo(sb, indentLevel + 1);
        sb.Append('\n');
        sb.Append(Indent(indentLevel));
        sb.Append('}');
    }
}
