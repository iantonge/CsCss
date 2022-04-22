using CsCss.Values;
using CsCss.Values.Global;
using CsCss.Values.Line;

namespace CsCss.Properties.BorderStyle
{
    public class BorderStyleValue : Value
    {
        public BorderStyleValue(string v) : base(v) { }

        public static implicit operator BorderStyleValue(GlobalKeyword value)
        {
            return new BorderStyleValue(value.ToString());
        }

        public static implicit operator BorderStyleValue(LineStyleValue value)
        {
            return new BorderStyleValue(value.ToString());
        }

        public static implicit operator BorderStyleValue((LineStyleValue hValue, LineStyleValue vValue) value)
        {
            return new BorderStyleValue(value.hValue.ToString() + " " + value.vValue.ToString());
        }

        public static implicit operator BorderStyleValue((LineStyleValue topValue, LineStyleValue vValue, LineStyleValue bottomValue) value)
        {
            return new BorderStyleValue(value.topValue.ToString() + " " + value.vValue.ToString() + " " + value.bottomValue.ToString());
        }

        public static implicit operator BorderStyleValue((LineStyleValue topValue, LineStyleValue rightValue, LineStyleValue bottomValue, LineStyleValue leftValue) value)
        {
            return new BorderStyleValue(value.topValue.ToString() + " " + value.rightValue.ToString() + " " + value.bottomValue.ToString() + " " + value.leftValue.ToString());
        }
    }
}
