using CsCss.Properties.BorderWidth;

namespace CsCss
{
    public sealed partial class Declarations
    {
        public BorderWidthValue this[BorderWidthProperty property]
        {
            set => declarations.Add((property, value));
        }

        public DirectionalBorderWidthValue this[DirectionalBorderWidthProperty property]
        {
            set => declarations.Add((property, value));
        }
    }
}
