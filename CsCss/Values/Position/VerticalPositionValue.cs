namespace CsCss.Values.Position
{
    public sealed class VerticalPositionValue : PositionValue
    {
        private VerticalPositionValue(string v) : base(v) { }

        internal static readonly VerticalPositionValue Top = new VerticalPositionValue("top");

        internal static readonly VerticalPositionValue Bottom = new VerticalPositionValue("bottom");

        public static implicit operator VerticalPositionValue(CenterPositionValue value)
        {
            return new VerticalPositionValue(value.ToString());
        }
    }
}
