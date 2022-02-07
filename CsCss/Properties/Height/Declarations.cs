using CsCss.Properties.Height;

namespace CsCss
{
    public sealed partial class Declarations
    {
        public HeightValue this[HeightProperty property]
        {
            set => declarations.Add((property, value));
        }
    }
}
