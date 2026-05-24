using CsCss.Values;
using CsCss.Values.General;
using CsCss.Values.Global;
using CsCss.Values.Length;
using CsCss.Values.LengthPercentage;
using CsCss.Values.Percentage;
using CsCss.Values.Position;

namespace CsCss.Properties.BackgroundPosition;

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
        return new BackgroundPositionValue($"{value.h} {value.v}");
    }

    public static implicit operator BackgroundPositionValue((LengthValue h, PercentageValue v) value)
    {
        return new BackgroundPositionValue($"{value.h} {value.v}");
    }

    public static implicit operator BackgroundPositionValue((LengthValue h, LengthPercentageValue v) value)
    {
        return new BackgroundPositionValue($"{value.h} {value.v}");
    }

    public static implicit operator BackgroundPositionValue((PercentageValue h, LengthValue v) value)
    {
        return new BackgroundPositionValue($"{value.h} {value.v}");
    }

    public static implicit operator BackgroundPositionValue((PercentageValue h, PercentageValue v) value)
    {
        return new BackgroundPositionValue($"{value.h} {value.v}");
    }

    public static implicit operator BackgroundPositionValue((PercentageValue h, LengthPercentageValue v) value)
    {
        return new BackgroundPositionValue($"{value.h} {value.v}");
    }

    public static implicit operator BackgroundPositionValue((LengthPercentageValue h, LengthValue v) value)
    {
        return new BackgroundPositionValue($"{value.h} {value.v}");
    }

    public static implicit operator BackgroundPositionValue((LengthPercentageValue h, PercentageValue v) value)
    {
        return new BackgroundPositionValue($"{value.h} {value.v}");
    }

    public static implicit operator BackgroundPositionValue((LengthPercentageValue h, LengthPercentageValue v) value)
    {
        return new BackgroundPositionValue($"{value.h} {value.v}");
    }

    public static implicit operator BackgroundPositionValue((HorizontalPositionValue h, VerticalPositionValue v) value)
    {
        return new BackgroundPositionValue($"{value.h} {value.v}");
    }

    public static implicit operator BackgroundPositionValue((VerticalPositionValue v, HorizontalPositionValue h) value)
    {
        return new BackgroundPositionValue($"{value.v} {value.h}");
    }

    public static implicit operator BackgroundPositionValue((CenterPositionValue c, VerticalPositionValue v) value)
    {
        return new BackgroundPositionValue($"{value.c} {value.v}");
    }

    public static implicit operator BackgroundPositionValue((CenterPositionValue c, HorizontalPositionValue h) value)
    {
        return new BackgroundPositionValue($"{value.c} {value.h}");
    }

    public static implicit operator BackgroundPositionValue((HorizontalPositionValue h, CenterPositionValue c) value)
    {
        return new BackgroundPositionValue($"{value.h} {value.c}");
    }

    public static implicit operator BackgroundPositionValue((VerticalPositionValue v, CenterPositionValue c) value)
    {
        return new BackgroundPositionValue($"{value.v} {value.c}");
    }

    public static implicit operator BackgroundPositionValue((CenterPositionValue c1, CenterPositionValue c2) value)
    {
        return new BackgroundPositionValue($"{value.c1} {value.c2}");
    }

    public static implicit operator BackgroundPositionValue((HorizontalPositionValue h, LengthPercentageValue hl, VerticalPositionValue v) value)
    {
        return new BackgroundPositionValue($"{value.h} {value.hl} {value.v}");
    }

    public static implicit operator BackgroundPositionValue((VerticalPositionValue v, LengthPercentageValue vl, HorizontalPositionValue h) value)
    {
        return new BackgroundPositionValue($"{value.v} {value.vl} {value.h}");
    }

    public static implicit operator BackgroundPositionValue((HorizontalPositionValue h, LengthPercentageValue hl, CenterPositionValue c) value)
    {
        return new BackgroundPositionValue($"{value.h} {value.hl} {value.c}");
    }

    public static implicit operator BackgroundPositionValue((VerticalPositionValue v, LengthPercentageValue vl, CenterPositionValue c) value)
    {
        return new BackgroundPositionValue($"{value.v} {value.vl} {value.c}");
    }

    public static implicit operator BackgroundPositionValue((CenterPositionValue c, LengthPercentageValue cl, VerticalPositionValue v) value)
    {
        return new BackgroundPositionValue($"{value.c} {value.cl} {value.v}");
    }

    public static implicit operator BackgroundPositionValue((CenterPositionValue c, LengthPercentageValue cl, HorizontalPositionValue h) value)
    {
        return new BackgroundPositionValue($"{value.c} {value.cl} {value.h}");
    }

    public static implicit operator BackgroundPositionValue((CenterPositionValue c1, LengthPercentageValue c1l, CenterPositionValue c2) value)
    {
        return new BackgroundPositionValue($"{value.c1} {value.c1l} {value.c2}");
    }

    public static implicit operator BackgroundPositionValue((HorizontalPositionValue h, VerticalPositionValue v, LengthPercentageValue vl) value)
    {
        return new BackgroundPositionValue($"{value.h} {value.v} {value.vl}");
    }

    public static implicit operator BackgroundPositionValue((VerticalPositionValue v, HorizontalPositionValue h, LengthPercentageValue hl) value)
    {
        return new BackgroundPositionValue($"{value.v} {value.h} {value.hl}");
    }

    public static implicit operator BackgroundPositionValue((HorizontalPositionValue h, CenterPositionValue c, LengthPercentageValue cl) value)
    {
        return new BackgroundPositionValue($"{value.h} {value.c} {value.cl}");
    }

    public static implicit operator BackgroundPositionValue((VerticalPositionValue v, CenterPositionValue c, LengthPercentageValue cl) value)
    {
        return new BackgroundPositionValue($"{value.v} {value.c} {value.cl}");
    }

    public static implicit operator BackgroundPositionValue((CenterPositionValue c, HorizontalPositionValue h, LengthPercentageValue hl) value)
    {
        return new BackgroundPositionValue($"{value.c} {value.h} {value.hl}");
    }

    public static implicit operator BackgroundPositionValue((CenterPositionValue c, VerticalPositionValue v, LengthPercentageValue vl) value)
    {
        return new BackgroundPositionValue($"{value.c} {value.v} {value.vl}");
    }

    public static implicit operator BackgroundPositionValue((CenterPositionValue c1, CenterPositionValue c2, LengthPercentageValue c2l) value)
    {
        return new BackgroundPositionValue($"{value.c2} {value.c2} {value.c2l}");
    }

    public static implicit operator BackgroundPositionValue((HorizontalPositionValue h, LengthPercentageValue hl, VerticalPositionValue v, LengthPercentageValue vl) value)
    {
        return new BackgroundPositionValue($"{value.h} {value.hl} {value.v} {value.vl}");
    }

    public static implicit operator BackgroundPositionValue((VerticalPositionValue v, LengthPercentageValue vl, HorizontalPositionValue h, LengthPercentageValue hl) value)
    {
        return new BackgroundPositionValue($"{value.v} {value.vl} {value.h} {value.hl}");
    }

    public static implicit operator BackgroundPositionValue((CenterPositionValue c, LengthPercentageValue cl, VerticalPositionValue v, LengthPercentageValue vl) value)
    {
        return new BackgroundPositionValue($"{value.c} {value.cl} {value.v} {value.vl}");
    }

    public static implicit operator BackgroundPositionValue((CenterPositionValue c, LengthPercentageValue cl, HorizontalPositionValue h, LengthPercentageValue hl) value)
    {
        return new BackgroundPositionValue($"{value.c} {value.cl} {value.h} {value.hl}");
    }

    public static implicit operator BackgroundPositionValue((HorizontalPositionValue h, LengthPercentageValue hl, CenterPositionValue c, LengthPercentageValue cl) value)
    {
        return new BackgroundPositionValue($"{value.h} {value.hl} {value.c} {value.cl}");
    }

    public static implicit operator BackgroundPositionValue((VerticalPositionValue v, LengthPercentageValue vl, CenterPositionValue c, LengthPercentageValue cl) value)
    {
        return new BackgroundPositionValue($"{value.v} {value.vl} {value.c} {value.cl}");
    }

    public static implicit operator BackgroundPositionValue((CenterPositionValue c1, LengthPercentageValue c1l, CenterPositionValue c2, LengthPercentageValue c2l) value)
    {
        return new BackgroundPositionValue($"{value.c1} {value.c1l} {value.c2} {value.c2l}");
    }
}
