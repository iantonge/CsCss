namespace CsCss.Properties.BorderStyle;

public sealed class DirectionalBorderStyleProperty : Property
{
    private DirectionalBorderStyleProperty(string v) : base(v) { }

    internal static readonly DirectionalBorderStyleProperty BorderTopStyle = new("border-top-style");
    internal static readonly DirectionalBorderStyleProperty BorderBottomStyle = new("border-bottom-style");
    internal static readonly DirectionalBorderStyleProperty BorderLeftStyle = new("border-left-style");
    internal static readonly DirectionalBorderStyleProperty BorderRightStyle = new("border-right-style");
}
