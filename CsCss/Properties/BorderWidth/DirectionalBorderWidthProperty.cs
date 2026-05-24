namespace CsCss.Properties.BorderWidth;

public sealed class DirectionalBorderWidthProperty : Property
{
    private DirectionalBorderWidthProperty(string v) : base(v) { }

    internal static readonly DirectionalBorderWidthProperty BorderTopWidth = new("border-top-width");
    internal static readonly DirectionalBorderWidthProperty BorderBottomWidth = new("border-bottom-width");
    internal static readonly DirectionalBorderWidthProperty BorderLeftWidth = new("border-left-width");
    internal static readonly DirectionalBorderWidthProperty BorderRightWidth = new("border-right-width");
}
