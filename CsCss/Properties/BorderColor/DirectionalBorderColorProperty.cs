namespace CsCss.Properties.BorderColor;

public sealed class DirectionalBorderColorProperty : Property
{
    private DirectionalBorderColorProperty(string v) : base(v) { }

    internal static readonly DirectionalBorderColorProperty BorderTopColor = new("border-top-color");
    internal static readonly DirectionalBorderColorProperty BorderBottomColor = new("border-bottom-color");
    internal static readonly DirectionalBorderColorProperty BorderLeftColor = new("border-left-color");
    internal static readonly DirectionalBorderColorProperty BorderRightColor = new("border-right-color");
}
