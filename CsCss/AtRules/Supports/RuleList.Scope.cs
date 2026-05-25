using CsCss.AtRules.Supports;

namespace CsCss;

public partial class RuleList
{
    public RuleList this[SupportsRuleScope supports]
    {
        init
        {
            Rules.Add(new SupportsRule(supports.Condition, value));
        }
    }
}
