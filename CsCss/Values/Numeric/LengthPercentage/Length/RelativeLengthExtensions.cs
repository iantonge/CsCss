using CsCss.Values.Numeric.LengthPercentage.Length;

namespace CsCss
{
    public static class RelativeLengthExtensions
    {
        public static LengthValue Em(this double input)
        {
            return new LengthValue(input, RelativeLengthUnit.Em);
        }

        public static LengthValue Em(this int input)
        {
            return new LengthValue(input, RelativeLengthUnit.Em);
        }
        public static LengthValue Ex(this double input)
        {
            return new LengthValue(input, RelativeLengthUnit.Ex);
        }

        public static LengthValue Ex(this int input)
        {
            return new LengthValue(input, RelativeLengthUnit.Ex);
        }
        public static LengthValue Ch(this double input)
        {
            return new LengthValue(input, RelativeLengthUnit.Ch);
        }

        public static LengthValue Ch(this int input)
        {
            return new LengthValue(input, RelativeLengthUnit.Ch);
        }
        public static LengthValue Rem(this double input)
        {
            return new LengthValue(input, RelativeLengthUnit.Rem);
        }

        public static LengthValue Rem(this int input)
        {
            return new LengthValue(input, RelativeLengthUnit.Rem);
        }
        public static LengthValue Lh(this double input)
        {
            return new LengthValue(input, RelativeLengthUnit.Lh);
        }

        public static LengthValue Lh(this int input)
        {
            return new LengthValue(input, RelativeLengthUnit.Lh);
        }
        public static LengthValue Vw(this double input)
        {
            return new LengthValue(input, RelativeLengthUnit.Vw);
        }

        public static LengthValue Vw(this int input)
        {
            return new LengthValue(input, RelativeLengthUnit.Vw);
        }
        public static LengthValue Vh(this double input)
        {
            return new LengthValue(input, RelativeLengthUnit.Vh);
        }

        public static LengthValue Vh(this int input)
        {
            return new LengthValue(input, RelativeLengthUnit.Vh);
        }
        public static LengthValue VMin(this double input)
        {
            return new LengthValue(input, RelativeLengthUnit.Vh);
        }

        public static LengthValue VMin(this int input)
        {
            return new LengthValue(input, RelativeLengthUnit.Vh);
        }
        public static LengthValue VMax(this double input)
        {
            return new LengthValue(input, RelativeLengthUnit.VMax);
        }

        public static LengthValue VMax(this int input)
        {
            return new LengthValue(input, RelativeLengthUnit.VMax);
        }
    }
}