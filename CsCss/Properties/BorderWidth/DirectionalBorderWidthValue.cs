using CsCss.Values;
using CsCss.Values.Global;
using CsCss.Values.Length;
using CsCss.Values.Line;

namespace CsCss.Properties.BorderWidth
{
    public class DirectionalBorderWidthValue : Value
    {
        public DirectionalBorderWidthValue(string v) : base(v) { }

        public static implicit operator DirectionalBorderWidthValue(GlobalKeyword value)
        {
            return new DirectionalBorderWidthValue(value.ToString());
        }

        public static implicit operator DirectionalBorderWidthValue(LengthValue value)
        {
            return new DirectionalBorderWidthValue(value.ToString());
        }

        public static implicit operator DirectionalBorderWidthValue(LineWidthValue value)
        {
            return new DirectionalBorderWidthValue(value.ToString());
        }
    }
}
