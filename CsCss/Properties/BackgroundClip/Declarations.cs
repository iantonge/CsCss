using CsCss.Properties.BackgroundClip;

namespace CsCss
{
    public sealed partial class Declarations
    {
        public BackgroundClipValue this[BackgroundClipProperty property]
        {
            set => declarations.Add((property, value));
        }
    }
}
