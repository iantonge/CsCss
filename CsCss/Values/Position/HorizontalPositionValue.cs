namespace CsCss.Values.Position;

public sealed class HorizontalPositionValue : PositionValue
{
    private HorizontalPositionValue(string v) : base(v) { }

    internal static readonly HorizontalPositionValue Left = new("left");
    internal static readonly HorizontalPositionValue Right = new("right");
}
