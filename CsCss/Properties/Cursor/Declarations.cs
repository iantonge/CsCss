using CsCss.Properties.Cursor;

namespace CsCss
{
    public sealed partial class Declarations
    {
        public CursorValue this[CursorProperty property]
        {
            set => declarations.Add((property, value));
        }
    }
}
