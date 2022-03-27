using CsCss.Properties.BackgroundSize;

namespace CsCss
{
    public sealed partial class Declarations
    {
        public BackgroundSizeValue this[BackgroundSizeProperty property]
        {
            set => declarations.Add((property, value));
        }
    }
}
