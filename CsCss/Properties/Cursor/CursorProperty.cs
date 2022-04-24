namespace CsCss.Properties.Cursor
{
    public sealed class CursorProperty : Property
    {
        private CursorProperty() : base("clear") { }

        internal static readonly CursorProperty Cursor = new CursorProperty();
    }
}
