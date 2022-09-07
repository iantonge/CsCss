using CsCss.Properties.AlignSelf;

namespace CsCss
{
    public sealed partial class Declarations
    {
        public AlignSelfValue this[AlignSelfProperty property]
        {
            set => declarations.Add((property, value));
        }
    }
}
