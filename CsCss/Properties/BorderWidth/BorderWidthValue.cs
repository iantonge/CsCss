using CsCss.Values;
using CsCss.Values.Global;
using CsCss.Values.Length;
using CsCss.Values.Line;

namespace CsCss.Properties.BorderWidth
{
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
            return new BorderWidthValue(value.hValue.ToString() + " " + value.vValue.ToString());
        }

        public static implicit operator BorderWidthValue((LineWidthValue topValue, LineWidthValue vValue, LineWidthValue bottomValue) value)
        {
            return new BorderWidthValue(value.topValue.ToString() + " " + value.vValue.ToString() + " " + value.bottomValue.ToString());
        }

        public static implicit operator BorderWidthValue((LineWidthValue topValue, LineWidthValue rightValue, LineWidthValue bottomValue, LineWidthValue leftValue) value)
        {
            return new BorderWidthValue(value.topValue.ToString() + " " + value.rightValue.ToString() + " " + value.bottomValue.ToString() + " " + value.leftValue.ToString());
        }
    }
}
