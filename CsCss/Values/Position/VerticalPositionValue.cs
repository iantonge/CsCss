namespace CsCss.Values.Position
{
    public sealed class VerticalPositionValue : PositionValue
    {
        private VerticalPositionValue(string v) : base(v) { }

        internal static readonly VerticalPositionValue Top = new VerticalPositionValue("top");

        internal static readonly VerticalPositionValue Bottom = new VerticalPositionValue("bottom");
    }
}
