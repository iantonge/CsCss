using CsCss.Properties.BackgroundColor;

namespace CsCss
{
    public sealed partial class Declarations
    {
        public BackgroundColorValue this[BackgroundColorProperty property]
        {
            set => declarations.Add((property, value));
        }
    }
}
