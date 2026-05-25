using CsCss.AtRules.FontFace;

namespace CsCss;

public partial class RuleList
{
    public FontFaceDescriptors this[FontFaceAtRule atRule]
    {
        init
        {
            Rules.Add(new FontFaceRule(value));
        }
    }
}
