using System.Text;

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

    internal override void AppendTo(StringBuilder sb, int indentLevel)
    {
        sb.Append(Indent(indentLevel));
        sb.Append("@supports ");
        sb.Append(condition);
        sb.Append(" {");
        rules.AppendTo(sb, indentLevel + 1);
        sb.Append('\n');
        sb.Append(Indent(indentLevel));
        sb.Append('}');
    }
}
