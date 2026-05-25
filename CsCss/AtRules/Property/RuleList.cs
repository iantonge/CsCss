using CsCss.AtRules.Property;

namespace CsCss;

public partial class RuleList
{
    public PropertyDescriptors this[PropertyAtRule atRule, string name]
    {
        init
        {
            Rules.Add(new PropertyRule(name, value));
        }
    }
}
