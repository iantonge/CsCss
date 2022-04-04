namespace CsCss.Properties.BorderColor
{
    public sealed class DirectionalBorderColorProperty : Property
    {
        private DirectionalBorderColorProperty(string v) : base(v) { }

        internal static readonly DirectionalBorderColorProperty BorderTopColor = new DirectionalBorderColorProperty("border-top-color");
        internal static readonly DirectionalBorderColorProperty BorderBottomColor = new DirectionalBorderColorProperty("border-bottom-color");
        internal static readonly DirectionalBorderColorProperty BorderLeftColor = new DirectionalBorderColorProperty("border-left-color");
        internal static readonly DirectionalBorderColorProperty BorderRightColor = new DirectionalBorderColorProperty("border-right-color");
    }
}
