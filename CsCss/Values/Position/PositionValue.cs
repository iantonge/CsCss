using CsCss.Values.LengthPercentage;

namespace CsCss.Values.Position
{
    public class PositionValue : Value
    {
        internal PositionValue(string v) : base(v) { }

        public static implicit operator PositionValue(LengthPercentageValue value)
        {
            return new PositionValue(value.ToString());
        }

        public static implicit operator PositionValue((HorizontalPositionValue h, VerticalPositionValue v) value)
        {
            return new PositionValue(value.h.ToString() + " " + value.v.ToString());
        }

        public static implicit operator PositionValue((VerticalPositionValue v, HorizontalPositionValue h) value)
        {
            return new PositionValue(value.v.ToString() + " " + value.h.ToString());
        }

        public static implicit operator PositionValue((CenterPositionValue c, VerticalPositionValue v) value)
        {
            return new PositionValue(value.c.ToString() + " " + value.v.ToString());
        }

        public static implicit operator PositionValue((CenterPositionValue c, HorizontalPositionValue h) value)
        {
            return new PositionValue(value.c.ToString() + " " + value.h.ToString());
        }

        public static implicit operator PositionValue((HorizontalPositionValue h, CenterPositionValue c) value)
        {
            return new PositionValue(value.h.ToString() + " " + value.c.ToString());
        }

        public static implicit operator PositionValue((VerticalPositionValue v, CenterPositionValue c) value)
        {
            return new PositionValue(value.v.ToString() + " " + value.c.ToString());
        }

        public static implicit operator PositionValue((CenterPositionValue c1, CenterPositionValue c2) value)
        {
            return new PositionValue(value.c1.ToString() + " " + value.c2.ToString());
        }

        public static implicit operator PositionValue((HorizontalPositionValue h, LengthPercentageValue hl, VerticalPositionValue v) value)
        {
            return new PositionValue(value.h.ToString() + " " + value.hl.ToString() + " " + value.v.ToString());
        }

        public static implicit operator PositionValue((VerticalPositionValue v, LengthPercentageValue vl, HorizontalPositionValue h) value)
        {
            return new PositionValue(value.v.ToString() + " " + value.vl.ToString() + " " + value.h.ToString());
        }

        public static implicit operator PositionValue((HorizontalPositionValue h, LengthPercentageValue hl, CenterPositionValue c) value)
        {
            return new PositionValue(value.h.ToString() + " " + value.hl.ToString() + " " + value.c.ToString());
        }

        public static implicit operator PositionValue((VerticalPositionValue v, LengthPercentageValue vl, CenterPositionValue c) value)
        {
            return new PositionValue(value.v.ToString() + " " + value.vl.ToString() + " " + value.c.ToString());
        }

        public static implicit operator PositionValue((CenterPositionValue c, LengthPercentageValue cl, VerticalPositionValue v) value)
        {
            return new PositionValue(value.c.ToString() + " " + value.cl.ToString() + " " + value.v.ToString());
        }

        public static implicit operator PositionValue((CenterPositionValue c, LengthPercentageValue cl, HorizontalPositionValue h) value)
        {
            return new PositionValue(value.c.ToString() + " " + value.cl.ToString() + " " + value.h.ToString());
        }

        public static implicit operator PositionValue((CenterPositionValue c1, LengthPercentageValue c1l, CenterPositionValue c2) value)
        {
            return new PositionValue(value.c1.ToString() + " " + value.c1l.ToString() + " " + value.c2.ToString());
        }

        public static implicit operator PositionValue((HorizontalPositionValue h, VerticalPositionValue v, LengthPercentageValue vl) value)
        {
            return new PositionValue(value.h.ToString() + " " + value.v.ToString() + " " + value.vl.ToString());
        }

        public static implicit operator PositionValue((VerticalPositionValue v, HorizontalPositionValue h, LengthPercentageValue hl) value)
        {
            return new PositionValue(value.v.ToString() + " " + value.h.ToString() + " " + value.hl.ToString());
        }

        public static implicit operator PositionValue((HorizontalPositionValue h, CenterPositionValue c, LengthPercentageValue cl) value)
        {
            return new PositionValue(value.h.ToString() + " " + value.c.ToString() + " " + value.cl.ToString());
        }

        public static implicit operator PositionValue((VerticalPositionValue v, CenterPositionValue c, LengthPercentageValue cl) value)
        {
            return new PositionValue(value.v.ToString() + " " + value.c.ToString() + " " + value.cl.ToString());
        }

        public static implicit operator PositionValue((CenterPositionValue c, HorizontalPositionValue h, LengthPercentageValue hl) value)
        {
            return new PositionValue(value.c.ToString() + " " + value.h.ToString() + " " + value.hl.ToString());
        }

        public static implicit operator PositionValue((CenterPositionValue c, VerticalPositionValue v, LengthPercentageValue vl) value)
        {
            return new PositionValue(value.c.ToString() + " " + value.v.ToString() + " " + value.vl.ToString());
        }

        public static implicit operator PositionValue((CenterPositionValue c1, CenterPositionValue c2, LengthPercentageValue c2l) value)
        {
            return new PositionValue(value.c2.ToString() + " " + value.c2.ToString() + " " + value.c2l.ToString());
        }

        public static implicit operator PositionValue((HorizontalPositionValue h, LengthPercentageValue hl, VerticalPositionValue v, LengthPercentageValue vl) value)
        {
            return new PositionValue(value.h.ToString() + " " + value.hl.ToString() + " " + value.v.ToString() + " " + value.vl.ToString());
        }

        public static implicit operator PositionValue((VerticalPositionValue v, LengthPercentageValue vl, HorizontalPositionValue h, LengthPercentageValue hl) value)
        {
            return new PositionValue(value.v.ToString() + " " + value.vl.ToString() + " " + value.h.ToString() + " " + value.hl.ToString());
        }

        public static implicit operator PositionValue((CenterPositionValue c, LengthPercentageValue cl, VerticalPositionValue v, LengthPercentageValue vl) value)
        {
            return new PositionValue(value.c.ToString() + " " + value.cl.ToString() + " " + value.v.ToString() + " " + value.vl.ToString());
        }

        public static implicit operator PositionValue((CenterPositionValue c, LengthPercentageValue cl, HorizontalPositionValue h, LengthPercentageValue hl) value)
        {
            return new PositionValue(value.c.ToString() + " " + value.cl.ToString() + " " + value.h.ToString() + " " + value.hl.ToString());
        }

        public static implicit operator PositionValue((HorizontalPositionValue h, LengthPercentageValue hl, CenterPositionValue c, LengthPercentageValue cl) value)
        {
            return new PositionValue(value.h.ToString() + " " + value.hl.ToString() + " " + value.c.ToString() + " " + value.cl.ToString());
        }

        public static implicit operator PositionValue((VerticalPositionValue v, LengthPercentageValue vl, CenterPositionValue c, LengthPercentageValue cl) value)
        {
            return new PositionValue(value.v.ToString() + " " + value.vl.ToString() + " " + value.c.ToString() + " " + value.cl.ToString());
        }

        public static implicit operator PositionValue((CenterPositionValue c1, LengthPercentageValue c1l, CenterPositionValue c2, LengthPercentageValue c2l) value)
        {
            return new PositionValue(value.c1.ToString() + " " + value.c1l.ToString() + " " + value.c2.ToString() + " " + value.c2l.ToString());
        }
    }
}
