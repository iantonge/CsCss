using CsCss.Values;
using CsCss.Values.General;
using CsCss.Values.Global;
using CsCss.Values.Length;
using CsCss.Values.LengthPercentage;
using CsCss.Values.Percentage;
using CsCss.Values.Position;

namespace CsCss.Properties.BackgroundPosition
{
    public class BackgroundPositionValue : Value
    {
        public BackgroundPositionValue(string v) : base(v) { }

        public static implicit operator BackgroundPositionValue(PositionValue value)
        {
            return new BackgroundPositionValue(value.ToString());
        }

        public static implicit operator BackgroundPositionValue(GlobalKeyword value)
        {
            return new BackgroundPositionValue(value.ToString());
        }

        public static implicit operator BackgroundPositionValue(NoneKeyword value)
        {
            return new BackgroundPositionValue(value.ToString());
        }

        public static implicit operator BackgroundPositionValue(LengthValue value)
        {
            return new BackgroundPositionValue(value.ToString());
        }

        public static implicit operator BackgroundPositionValue(PercentageValue value)
        {
            return new BackgroundPositionValue(value.ToString());
        }

        public static implicit operator BackgroundPositionValue(LengthPercentageValue value)
        {
            return new BackgroundPositionValue(value.ToString());
        }

        public static implicit operator BackgroundPositionValue((LengthValue h, LengthValue v) value)
        {
            return new BackgroundPositionValue(value.h.ToString() + " " + value.v.ToString());
        }

        public static implicit operator BackgroundPositionValue((LengthValue h, PercentageValue v) value)
        {
            return new BackgroundPositionValue(value.h.ToString() + " " + value.v.ToString());
        }

        public static implicit operator BackgroundPositionValue((LengthValue h, LengthPercentageValue v) value)
        {
            return new BackgroundPositionValue(value.h.ToString() + " " + value.v.ToString());
        }

        public static implicit operator BackgroundPositionValue((PercentageValue h, LengthValue v) value)
        {
            return new BackgroundPositionValue(value.h.ToString() + " " + value.v.ToString());
        }

        public static implicit operator BackgroundPositionValue((PercentageValue h, PercentageValue v) value)
        {
            return new BackgroundPositionValue(value.h.ToString() + " " + value.v.ToString());
        }

        public static implicit operator BackgroundPositionValue((PercentageValue h, LengthPercentageValue v) value)
        {
            return new BackgroundPositionValue(value.h.ToString() + " " + value.v.ToString());
        }

        public static implicit operator BackgroundPositionValue((LengthPercentageValue h, LengthValue v) value)
        {
            return new BackgroundPositionValue(value.h.ToString() + " " + value.v.ToString());
        }

        public static implicit operator BackgroundPositionValue((LengthPercentageValue h, PercentageValue v) value)
        {
            return new BackgroundPositionValue(value.h.ToString() + " " + value.v.ToString());
        }

        public static implicit operator BackgroundPositionValue((LengthPercentageValue h, LengthPercentageValue v) value)
        {
            return new BackgroundPositionValue(value.h.ToString() + " " + value.v.ToString());
        }

        public static implicit operator BackgroundPositionValue((HorizontalPositionValue h, VerticalPositionValue v) value)
        {
            return new BackgroundPositionValue(value.h.ToString() + " " + value.v.ToString());
        }

        public static implicit operator BackgroundPositionValue((VerticalPositionValue v, HorizontalPositionValue h) value)
        {
            return new BackgroundPositionValue(value.v.ToString() + " " + value.h.ToString());
        }

        public static implicit operator BackgroundPositionValue((CenterPositionValue c, VerticalPositionValue v) value)
        {
            return new BackgroundPositionValue(value.c.ToString() + " " + value.v.ToString());
        }

        public static implicit operator BackgroundPositionValue((CenterPositionValue c, HorizontalPositionValue h) value)
        {
            return new BackgroundPositionValue(value.c.ToString() + " " + value.h.ToString());
        }

        public static implicit operator BackgroundPositionValue((HorizontalPositionValue h, CenterPositionValue c) value)
        {
            return new BackgroundPositionValue(value.h.ToString() + " " + value.c.ToString());
        }

        public static implicit operator BackgroundPositionValue((VerticalPositionValue v, CenterPositionValue c) value)
        {
            return new BackgroundPositionValue(value.v.ToString() + " " + value.c.ToString());
        }

        public static implicit operator BackgroundPositionValue((CenterPositionValue c1, CenterPositionValue c2) value)
        {
            return new BackgroundPositionValue(value.c1.ToString() + " " + value.c2.ToString());
        }

        public static implicit operator BackgroundPositionValue((HorizontalPositionValue h, LengthPercentageValue hl, VerticalPositionValue v) value)
        {
            return new BackgroundPositionValue(value.h.ToString() + " " + value.hl.ToString() + " " + value.v.ToString());
        }

        public static implicit operator BackgroundPositionValue((VerticalPositionValue v, LengthPercentageValue vl, HorizontalPositionValue h) value)
        {
            return new BackgroundPositionValue(value.v.ToString() + " " + value.vl.ToString() + " " + value.h.ToString());
        }

        public static implicit operator BackgroundPositionValue((HorizontalPositionValue h, LengthPercentageValue hl, CenterPositionValue c) value)
        {
            return new BackgroundPositionValue(value.h.ToString() + " " + value.hl.ToString() + " " + value.c.ToString());
        }

        public static implicit operator BackgroundPositionValue((VerticalPositionValue v, LengthPercentageValue vl, CenterPositionValue c) value)
        {
            return new BackgroundPositionValue(value.v.ToString() + " " + value.vl.ToString() + " " + value.c.ToString());
        }

        public static implicit operator BackgroundPositionValue((CenterPositionValue c, LengthPercentageValue cl, VerticalPositionValue v) value)
        {
            return new BackgroundPositionValue(value.c.ToString() + " " + value.cl.ToString() + " " + value.v.ToString());
        }

        public static implicit operator BackgroundPositionValue((CenterPositionValue c, LengthPercentageValue cl, HorizontalPositionValue h) value)
        {
            return new BackgroundPositionValue(value.c.ToString() + " " + value.cl.ToString() + " " + value.h.ToString());
        }

        public static implicit operator BackgroundPositionValue((CenterPositionValue c1, LengthPercentageValue c1l, CenterPositionValue c2) value)
        {
            return new BackgroundPositionValue(value.c1.ToString() + " " + value.c1l.ToString() + " " + value.c2.ToString());
        }

        public static implicit operator BackgroundPositionValue((HorizontalPositionValue h, VerticalPositionValue v, LengthPercentageValue vl) value)
        {
            return new BackgroundPositionValue(value.h.ToString() + " " + value.v.ToString() + " " + value.vl.ToString());
        }

        public static implicit operator BackgroundPositionValue((VerticalPositionValue v, HorizontalPositionValue h, LengthPercentageValue hl) value)
        {
            return new BackgroundPositionValue(value.v.ToString() + " " + value.h.ToString() + " " + value.hl.ToString());
        }

        public static implicit operator BackgroundPositionValue((HorizontalPositionValue h, CenterPositionValue c, LengthPercentageValue cl) value)
        {
            return new BackgroundPositionValue(value.h.ToString() + " " + value.c.ToString() + " " + value.cl.ToString());
        }

        public static implicit operator BackgroundPositionValue((VerticalPositionValue v, CenterPositionValue c, LengthPercentageValue cl) value)
        {
            return new BackgroundPositionValue(value.v.ToString() + " " + value.c.ToString() + " " + value.cl.ToString());
        }

        public static implicit operator BackgroundPositionValue((CenterPositionValue c, HorizontalPositionValue h, LengthPercentageValue hl) value)
        {
            return new BackgroundPositionValue(value.c.ToString() + " " + value.h.ToString() + " " + value.hl.ToString());
        }

        public static implicit operator BackgroundPositionValue((CenterPositionValue c, VerticalPositionValue v, LengthPercentageValue vl) value)
        {
            return new BackgroundPositionValue(value.c.ToString() + " " + value.v.ToString() + " " + value.vl.ToString());
        }

        public static implicit operator BackgroundPositionValue((CenterPositionValue c1, CenterPositionValue c2, LengthPercentageValue c2l) value)
        {
            return new BackgroundPositionValue(value.c2.ToString() + " " + value.c2.ToString() + " " + value.c2l.ToString());
        }

        public static implicit operator BackgroundPositionValue((HorizontalPositionValue h, LengthPercentageValue hl, VerticalPositionValue v, LengthPercentageValue vl) value)
        {
            return new BackgroundPositionValue(value.h.ToString() + " " + value.hl.ToString() + " " + value.v.ToString() + " " + value.vl.ToString());
        }

        public static implicit operator BackgroundPositionValue((VerticalPositionValue v, LengthPercentageValue vl, HorizontalPositionValue h, LengthPercentageValue hl) value)
        {
            return new BackgroundPositionValue(value.v.ToString() + " " + value.vl.ToString() + " " + value.h.ToString() + " " + value.hl.ToString());
        }

        public static implicit operator BackgroundPositionValue((CenterPositionValue c, LengthPercentageValue cl, VerticalPositionValue v, LengthPercentageValue vl) value)
        {
            return new BackgroundPositionValue(value.c.ToString() + " " + value.cl.ToString() + " " + value.v.ToString() + " " + value.vl.ToString());
        }

        public static implicit operator BackgroundPositionValue((CenterPositionValue c, LengthPercentageValue cl, HorizontalPositionValue h, LengthPercentageValue hl) value)
        {
            return new BackgroundPositionValue(value.c.ToString() + " " + value.cl.ToString() + " " + value.h.ToString() + " " + value.hl.ToString());
        }

        public static implicit operator BackgroundPositionValue((HorizontalPositionValue h, LengthPercentageValue hl, CenterPositionValue c, LengthPercentageValue cl) value)
        {
            return new BackgroundPositionValue(value.h.ToString() + " " + value.hl.ToString() + " " + value.c.ToString() + " " + value.cl.ToString());
        }

        public static implicit operator BackgroundPositionValue((VerticalPositionValue v, LengthPercentageValue vl, CenterPositionValue c, LengthPercentageValue cl) value)
        {
            return new BackgroundPositionValue(value.v.ToString() + " " + value.vl.ToString() + " " + value.c.ToString() + " " + value.cl.ToString());
        }

        public static implicit operator BackgroundPositionValue((CenterPositionValue c1, LengthPercentageValue c1l, CenterPositionValue c2, LengthPercentageValue c2l) value)
        {
            return new BackgroundPositionValue(value.c1.ToString() + " " + value.c1l.ToString() + " " + value.c2.ToString() + " " + value.c2l.ToString());
        }
    }
}
