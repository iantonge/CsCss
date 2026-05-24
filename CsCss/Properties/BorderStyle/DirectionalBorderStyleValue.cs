using CsCss.Values;
using CsCss.Values.Global;
using CsCss.Values.Line;

namespace CsCss.Properties.BorderStyle;

public class DirectionalBorderStyleValue : Value
{
    public DirectionalBorderStyleValue(string v) : base(v) { }

    public static implicit operator DirectionalBorderStyleValue(GlobalKeyword value)
    {
        return new(value.ToString());
    }

    public static implicit operator DirectionalBorderStyleValue(LineStyleValue value)
    {
        return new(value.ToString());
    }
}
