using CsCss.Properties.BackgroundImage;

namespace CsCss
{
    public sealed partial class Declarations
    {
        public BackgroundImageValue this[BackgroundImageProperty property]
        {
            set => declarations.Add((property, value));
        }
    }
}
