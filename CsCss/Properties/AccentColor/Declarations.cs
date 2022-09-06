using CsCss.Properties.AccentColor;

namespace CsCss
{
    public sealed partial class Declarations
    {
        public AccentColorValue this[AccentColorProperty property]
        {
            set => declarations.Add((property, value));
        }
    }
}
