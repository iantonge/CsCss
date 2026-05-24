using CsCss.Values.Angle;

namespace CsCss.Values.Color.Function;

public sealed class HueValue
{
    private readonly string value;

    private HueValue(string v) => value = v;

    public override string ToString() => value;

    public static implicit operator HueValue(int value)
    {
        return new(value.ToString());
    }

    public static implicit operator HueValue(double value)
    {
        return new(value.ToString());
    }

    public static implicit operator HueValue(AngleValue value)
    {
        return new(value.ToString());
    }
}
