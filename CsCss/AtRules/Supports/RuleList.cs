using CsCss.AtRules.Supports;

namespace CsCss;

public partial class RuleList
{
    public RuleList this[SupportsAtRule atRule, SupportsCondition condition]
    {
        init
        {
            Rules.Add(new SupportsRule(condition, value));
        }
    }
}
