namespace CsCss.Properties.BorderStyle
{
    public sealed class DirectionalBorderStyleProperty : Property
    {
        private DirectionalBorderStyleProperty(string v) : base(v) { }

        internal static readonly DirectionalBorderStyleProperty BorderTopStyle = new DirectionalBorderStyleProperty("border-top-style");
        internal static readonly DirectionalBorderStyleProperty BorderBottomStyle = new DirectionalBorderStyleProperty("border-bottom-style");
        internal static readonly DirectionalBorderStyleProperty BorderLeftStyle = new DirectionalBorderStyleProperty("border-left-style");
        internal static readonly DirectionalBorderStyleProperty BorderRightStyle = new DirectionalBorderStyleProperty("border-right-style");
    }
}
