using CsCss.AtRules;

namespace CsCss;

public partial class RuleList
{
    public Keyframes this[KeyframesAtRule atRule, string name]
    {
        init
        {
            Rules.Add(new KeyframesRule(name, value));
        }
    }
}
