using CsCss.Values.Angle;

namespace CsCss.Values.Gradient.Linear;

public sealed class LinearGradientDirection
{
    private readonly string value;

    private LinearGradientDirection(string v) => value = v;

    public override string ToString() => value;

    public static implicit operator LinearGradientDirection(AngleValue value)
    {
        return new LinearGradientDirection(value.ToString());
    }

    internal static readonly LinearGradientDirection ToLeftTop = new("to left top");
    internal static readonly LinearGradientDirection ToTop = new("to top");
    internal static readonly LinearGradientDirection ToRightTop = new("to right top");
    internal static readonly LinearGradientDirection ToRight = new("to right");
    internal static readonly LinearGradientDirection ToRightBottom = new("to right bottom");
    internal static readonly LinearGradientDirection ToBottom = new("to bottom");
    internal static readonly LinearGradientDirection ToLeftBottom = new("to left bottom");
    internal static readonly LinearGradientDirection ToLeft = new("to left");
}
