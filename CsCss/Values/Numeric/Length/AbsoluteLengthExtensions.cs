using CsCss.Values.Numeric.Length;

namespace CsCss
{
    public static class AbsoluteLengthExtensions
    {
        public static LengthValue Cm(this double input)
        {
            return new LengthValue(input, AbsoluteLengthUnit.Cm);
        }

        public static LengthValue Cm(this int input)
        {
            return new LengthValue(input, AbsoluteLengthUnit.Cm);
        }
        public static LengthValue Mm(this double input)
        {
            return new LengthValue(input, AbsoluteLengthUnit.Mm);
        }

        public static LengthValue Mm(this int input)
        {
            return new LengthValue(input, AbsoluteLengthUnit.Mm);
        }

        public static LengthValue Q(this double input)
        {
            return new LengthValue(input, AbsoluteLengthUnit.Q);
        }

        public static LengthValue Q(this int input)
        {
            return new LengthValue(input, AbsoluteLengthUnit.Q);
        }

        public static LengthValue In(this double input)
        {
            return new LengthValue(input, AbsoluteLengthUnit.In);
        }

        public static LengthValue In(this int input)
        {
            return new LengthValue(input, AbsoluteLengthUnit.In);
        }
        public static LengthValue Pc(this double input)
        {
            return new LengthValue(input, AbsoluteLengthUnit.Pc);
        }

        public static LengthValue Pc(this int input)
        {
            return new LengthValue(input, AbsoluteLengthUnit.Pc);
        }

        public static LengthValue Pt(this double input)
        {
            return new LengthValue(input, AbsoluteLengthUnit.Pt);
        }

        public static LengthValue Pt(this int input)
        {
            return new LengthValue(input, AbsoluteLengthUnit.Pt);
        }

        public static LengthValue Px(this double input)
        {
            return new LengthValue(input, AbsoluteLengthUnit.Px);
        }

        public static LengthValue Px(this int input)
        {
            return new LengthValue(input, AbsoluteLengthUnit.Px);
        }
    }
}