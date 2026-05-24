using CsCss.Values.Length;

namespace CsCss;

public static class AbsoluteLengthExtensions
{
    public static LengthValue Cm(this double input) => new(input, AbsoluteLengthUnit.Cm);

    public static LengthValue Cm(this int input) => new(input, AbsoluteLengthUnit.Cm);
    public static LengthValue Mm(this double input) => new(input, AbsoluteLengthUnit.Mm);

    public static LengthValue Mm(this int input) => new(input, AbsoluteLengthUnit.Mm);

    public static LengthValue Q(this double input) => new(input, AbsoluteLengthUnit.Q);

    public static LengthValue Q(this int input) => new(input, AbsoluteLengthUnit.Q);

    public static LengthValue In(this double input) => new(input, AbsoluteLengthUnit.In);

    public static LengthValue In(this int input) => new(input, AbsoluteLengthUnit.In);
    public static LengthValue Pc(this double input) => new(input, AbsoluteLengthUnit.Pc);

    public static LengthValue Pc(this int input) => new(input, AbsoluteLengthUnit.Pc);

    public static LengthValue Pt(this double input) => new(input, AbsoluteLengthUnit.Pt);

    public static LengthValue Pt(this int input) => new(input, AbsoluteLengthUnit.Pt);

    public static LengthValue Px(this double input) => new(input, AbsoluteLengthUnit.Px);

    public static LengthValue Px(this int input) => new(input, AbsoluteLengthUnit.Px);
}