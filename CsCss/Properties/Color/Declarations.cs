using CsCss.Properties.Color;
using CsCss.Values.Color;

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
