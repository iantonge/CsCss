using CsCss.Properties.Color;

namespace CsCss
{
    public sealed partial class Declarations
    {
        public ColorValue this[ColorProperty property]
        {
            set => declarations.Add((property, value));
        }
    }
}
