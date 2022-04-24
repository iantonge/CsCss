namespace CsCss.Values.Position
{
    public sealed class BothPositionValue : Value
    {
        private BothPositionValue(string v) : base(v) { }

        internal static readonly BothPositionValue Both = new BothPositionValue("both");
    }
}
