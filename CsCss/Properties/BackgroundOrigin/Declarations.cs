using CsCss.Properties.BackgroundOrigin;

namespace CsCss
{
    public sealed partial class Declarations
    {
        public BackgroundOriginValue this[BackgroundOriginProperty property]
        {
            set => declarations.Add((property, value));
        }
    }
}
