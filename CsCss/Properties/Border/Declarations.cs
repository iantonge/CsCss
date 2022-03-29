using CsCss.Properties.Border;

namespace CsCss
{
    public sealed partial class Declarations
    {
        public BorderValue this[BorderProperty property]
        {
            set => declarations.Add((property, value));
        }
    }
}
