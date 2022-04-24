namespace CsCss.Properties.Clear
{
    public sealed class ClearProperty : Property
    {
        private ClearProperty() : base("clear") { }

        internal static readonly ClearProperty Clear = new ClearProperty();
    }
}
