using CsCss.Values.Length;
using CsCss.Values.LengthPercentage;
using CsCss.Values.Percentage;

namespace CsCss.Values.Position
{
    public class PositionValue : Value
    {
        internal PositionValue(string v) : base(v) { }

        public static implicit operator PositionValue(LengthValue offset) => new PositionValue(offset.ToString());
        public static implicit operator PositionValue(PercentageValue offset) => new PositionValue(offset.ToString());
        public static implicit operator PositionValue(LengthPercentageValue offset) => new PositionValue(offset.ToString());

        public static implicit operator PositionValue((HorizontalPositionValue h, LengthPercentageValue hOffset) pos) => new PositionValue(pos.h + " " + pos.hOffset);
        public static implicit operator PositionValue((VerticalPositionValue v, LengthPercentageValue vOffset) pos) => new PositionValue(pos.v + " " + pos.vOffset);
        public static implicit operator PositionValue((CenterPositionValue c, LengthPercentageValue cOffset) pos) => new PositionValue(pos.c + " " + pos.cOffset);

        public static implicit operator PositionValue((HorizontalPositionValue h, VerticalPositionValue v) pos) => new PositionValue(pos.h + " " + pos.v);
        public static implicit operator PositionValue((HorizontalPositionValue h, CenterPositionValue v) pos) => new PositionValue(pos.h + " " + pos.v);
        public static implicit operator PositionValue((VerticalPositionValue v, HorizontalPositionValue h) pos) => new PositionValue(pos.v + " " + pos.h);
        public static implicit operator PositionValue((VerticalPositionValue v, CenterPositionValue h) pos) => new PositionValue(pos.v + " " + pos.h);
        public static implicit operator PositionValue((CenterPositionValue v, HorizontalPositionValue h) pos) => new PositionValue(pos.v + " " + pos.h);
        public static implicit operator PositionValue((CenterPositionValue h, VerticalPositionValue v) pos) => new PositionValue(pos.h + " " + pos.v);
        public static implicit operator PositionValue((CenterPositionValue h, CenterPositionValue v) pos) => new PositionValue(pos.h + " " + pos.v);

        public static implicit operator PositionValue((HorizontalPositionValue h, LengthPercentageValue hOffset, VerticalPositionValue v, LengthPercentageValue vOffset) pos) => new PositionValue(pos.h + " " + pos.hOffset + " " + pos.v + " " + pos.vOffset);
        public static implicit operator PositionValue((HorizontalPositionValue h, LengthPercentageValue hOffset, CenterPositionValue v, LengthPercentageValue vOffset) pos) => new PositionValue(pos.h + " " + pos.hOffset + " " + pos.v + " " + pos.vOffset);
        public static implicit operator PositionValue((VerticalPositionValue v, LengthPercentageValue vOffset, HorizontalPositionValue h, LengthPercentageValue hOffset) pos) => new PositionValue(pos.v + " " + pos.vOffset + " " + pos.h + " " + pos.hOffset);
        public static implicit operator PositionValue((VerticalPositionValue v, LengthPercentageValue vOffset, CenterPositionValue h, LengthPercentageValue hOffset) pos) => new PositionValue(pos.v + " " + pos.vOffset + " " + pos.h + " " + pos.hOffset);
        public static implicit operator PositionValue((CenterPositionValue v, LengthPercentageValue vOffset, HorizontalPositionValue h, LengthPercentageValue hOffset) pos) => new PositionValue(pos.v + " " + pos.vOffset + " " + pos.h + " " + pos.hOffset);
        public static implicit operator PositionValue((CenterPositionValue h, LengthPercentageValue hOffset, VerticalPositionValue v, LengthPercentageValue vOffset) pos) => new PositionValue(pos.h + " " + pos.hOffset + " " + pos.v + " " + pos.vOffset);
        public static implicit operator PositionValue((CenterPositionValue h, LengthPercentageValue hOffset, CenterPositionValue v, LengthPercentageValue vOffset) pos) => new PositionValue(pos.h + " " + pos.hOffset + " " + pos.v + " " + pos.vOffset);
    }
}
