using CsCss.Properties.Clear;

namespace CsCss
{
    public sealed partial class Declarations
    {
        public ClearValue this[ClearProperty property]
        {
            set => declarations.Add((property, value));
        }
    }
}
