namespace CsCss.Properties.Border;

public sealed class BorderProperty : Property
{
    private BorderProperty(string v) : base(v) { }

    internal static readonly BorderProperty Border = new("border");
    internal static readonly BorderProperty BorderTop = new("border-top");
    internal static readonly BorderProperty BorderBottom = new("border-bottom");
    internal static readonly BorderProperty BorderLeft = new("border-left");
    internal static readonly BorderProperty BorderRight = new("border-right");
}
