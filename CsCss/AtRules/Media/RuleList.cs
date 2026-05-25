using CsCss.AtRules.Media;

namespace CsCss;

public partial class RuleList
{
    public RuleList this[MediaAtRule atRule, MediaQuery query]
    {
        init
        {
            Rules.Add(new MediaRule(query, value));
        }
    }
}
