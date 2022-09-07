using CsCss.Properties.All;
using CsCss.Values.Global;

namespace CsCss
{
    public sealed partial class Declarations
    {
        public GlobalKeyword this[AllProperty property]
        {
            set => declarations.Add((property, value));
        }
    }
}
