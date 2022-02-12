namespace CsCss.Values.Position
{
    public sealed class CenterPositionValue : PositionValue
    {
        private CenterPositionValue(string v) : base(v) { }

        internal static readonly CenterPositionValue Center = new CenterPositionValue("center");
    }
}
