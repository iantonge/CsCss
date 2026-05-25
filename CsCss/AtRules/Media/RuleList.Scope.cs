using CsCss.AtRules.Media;

namespace CsCss;

public partial class RuleList
{
    public RuleList this[MediaRuleScope media]
    {
        init
        {
            Rules.Add(new MediaRule(media.Query, value));
        }
    }
}
