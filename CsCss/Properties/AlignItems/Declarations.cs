using CsCss.Properties.AlignItems;

namespace CsCss
{
    public sealed partial class Declarations
    {
        public AlignItemsValue this[AlignItemsProperty property]
        {
            set => declarations.Add((property, value));
        }
    }
}
