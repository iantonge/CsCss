using CsCss.Properties.BackgroundColor;
using CsCss.Values.Color;

namespace CsCss
{
    public sealed partial class Declarations
    {
        public ColorValue this[BackgroundColorProperty property]
        {
            set => declarations.Add((property, value));
        }
    }
}
