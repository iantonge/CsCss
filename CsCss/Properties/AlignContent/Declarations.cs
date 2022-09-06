using CsCss.Properties.AlignContent;

namespace CsCss
{
    public sealed partial class Declarations
    {
        public AlignContentValue this[AlignContentProperty property]
        {
            set => declarations.Add((property, value));
        }
    }
}
