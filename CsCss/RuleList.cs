using System.Text;

namespace CsCss;

public partial class RuleList
{
    internal readonly List<CssRule> Rules;

    public RuleList() => Rules = new();

    public RuleList(RuleList original) => Rules = original.Rules.ToList();

    public Declarations this[Selector ruleSelector]
    {
        init
        {
            Rules.Add(new StyleRule(ruleSelector, value));
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new();
        AppendTo(sb, 0);
        return sb.ToString();
    }

    internal void AppendTo(StringBuilder sb, int indentLevel)
    {
        foreach (var rule in Rules)
        {
            if (sb.Length > 0)
            {
                sb.Append('\n');
            }

            rule.AppendTo(sb, indentLevel);
        }
    }
}
