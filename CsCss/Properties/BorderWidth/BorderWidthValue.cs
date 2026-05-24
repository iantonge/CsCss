using CsCss.Values;
using CsCss.Values.Global;
using CsCss.Values.Length;
using CsCss.Values.Line;

namespace CsCss.Properties.BorderWidth;

public class BorderWidthValue : Value
{
    public BorderWidthValue(string v) : base(v) { }

    public static implicit operator BorderWidthValue(GlobalKeyword value)
    {
        return new BorderWidthValue(value.ToString());
    }

    public static implicit operator BorderWidthValue(LineWidthValue value)
    {
        return new BorderWidthValue(value.ToString());
    }

    public static implicit operator BorderWidthValue(LengthValue value)
    {
        return new BorderWidthValue(value.ToString());
    }

    public static implicit operator BorderWidthValue((LineWidthValue hValue, LineWidthValue vValue) value)
    {
        return new BorderWidthValue($"{value.hValue} {value.vValue}");
    }

    public static implicit operator BorderWidthValue((LineWidthValue topValue, LineWidthValue vValue, LineWidthValue bottomValue) value)
    {
        return new BorderWidthValue($"{value.topValue} {value.vValue} {value.bottomValue}");
    }

    public static implicit operator BorderWidthValue((LineWidthValue topValue, LineWidthValue rightValue, LineWidthValue bottomValue, LineWidthValue leftValue) value)
    {
        return new BorderWidthValue($"{value.topValue} {value.rightValue} {value.bottomValue} {value.leftValue}");
    }
}
