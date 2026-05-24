using CsCss.Values;
using CsCss.Values.Global;
using CsCss.Values.Line;

namespace CsCss.Properties.BorderStyle;

public class BorderStyleValue : Value
{
    public BorderStyleValue(string v) : base(v) { }

    public static implicit operator BorderStyleValue(GlobalKeyword value)
    {
        return new(value.ToString());
    }

    public static implicit operator BorderStyleValue(LineStyleValue value)
    {
        return new(value.ToString());
    }

    public static implicit operator BorderStyleValue((LineStyleValue hValue, LineStyleValue vValue) value)
    {
        return new($"{value.hValue} {value.vValue}");
    }

    public static implicit operator BorderStyleValue((LineStyleValue topValue, LineStyleValue vValue, LineStyleValue bottomValue) value)
    {
        return new($"{value.topValue} {value.vValue} {value.bottomValue}");
    }

    public static implicit operator BorderStyleValue((LineStyleValue topValue, LineStyleValue rightValue, LineStyleValue bottomValue, LineStyleValue leftValue) value)
    {
        return new($"{value.topValue} {value.rightValue} {value.bottomValue} {value.leftValue}");
    }
}
