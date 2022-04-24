using CsCss.Values;
using CsCss.Values.General;
using CsCss.Values.Global;
using CsCss.Values.Position;

namespace CsCss.Properties.Clear
{
    public class ClearValue : Value
    {
        public ClearValue(string v) : base(v) { }

        public static implicit operator ClearValue(GlobalKeyword value)
        {
            return new ClearValue(value.ToString());
        }

        public static implicit operator ClearValue(NoneKeyword value)
        {
            return new ClearValue(value.ToString());
        }

        public static implicit operator ClearValue(HorizontalPositionValue value)
        {
            return new ClearValue(value.ToString());
        }

        public static implicit operator ClearValue(BothPositionValue value)
        {
            return new ClearValue(value.ToString());
        }
    }
}
