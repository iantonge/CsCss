using CsCss.Properties.BorderColor;

namespace CsCss
{
    public sealed partial class Declarations
    {
        public BorderColorValue this[BorderColorProperty property]
        {
            set => declarations.Add((property, value));
        }

        public DirectionalBorderColorValue this[DirectionalBorderColorProperty property]
        {
            set => declarations.Add((property, value));
        }
    }
}
