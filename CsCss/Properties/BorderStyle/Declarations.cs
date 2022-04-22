using CsCss.Properties.BorderStyle;

namespace CsCss
{
    public sealed partial class Declarations
    {
        public BorderStyleValue this[BorderStyleProperty property]
        {
            set => declarations.Add((property, value));
        }

        public DirectionalBorderStyleValue this[DirectionalBorderStyleProperty property]
        {
            set => declarations.Add((property, value));
        }
    }
}
