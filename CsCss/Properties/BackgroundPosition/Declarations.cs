using CsCss.Properties.BackgroundPosition;

namespace CsCss
{
    public sealed partial class Declarations
    {
        public BackgroundPositionValue this[BackgroundPositionProperty property]
        {
            set => declarations.Add((property, value));
        }
    }
}
