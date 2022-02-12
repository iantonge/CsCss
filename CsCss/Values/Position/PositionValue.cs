using CsCss.Values.LengthPercentage;

namespace CsCss.Values.Position
{
    public class PositionValue : Value
    {
        internal PositionValue(string v) : base(v) { }

        public static implicit operator PositionValue((HorizontalPositionValue h, VerticalPositionValue v) value)
        {
            return new PositionValue(value.h.ToString() + " " + value.v.ToString());
        }

        public static implicit operator PositionValue((HorizontalPositionValue h, LengthPercentageValue hl, VerticalPositionValue v) value)
        {
            return new PositionValue(value.h.ToString() + " " + value.hl.ToString() + " " + value.v.ToString());
        }

        public static implicit operator PositionValue((HorizontalPositionValue h, VerticalPositionValue v, LengthPercentageValue vl) value)
        {
            return new PositionValue(value.h.ToString() + " " + value.v.ToString() + " " + value.vl.ToString());
        }

        public static implicit operator PositionValue((HorizontalPositionValue h, LengthPercentageValue hl, VerticalPositionValue v, LengthPercentageValue vl) value)
        {
            return new PositionValue(value.h.ToString() + " " + value.hl.ToString() + " " + value.v.ToString() + " " + value.vl.ToString());
        }
    }
}
