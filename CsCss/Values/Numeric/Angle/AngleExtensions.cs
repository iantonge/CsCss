using CsCss.Values.Numeric.Angle;

namespace CsCss
{
    public static class AngleExtensions
    {
        public static AngleValue Deg(this double input)
        {
            return new AngleValue(input, AngleUnit.Deg);
        }

        public static AngleValue Deg(this int input)
        {
            return new AngleValue(input, AngleUnit.Deg);
        }

        public static AngleValue Rad(this double input)
        {
            return new AngleValue(input, AngleUnit.Rad);
        }

        public static AngleValue Rad(this int input)
        {
            return new AngleValue(input, AngleUnit.Rad);
        }

        public static AngleValue Grad(this double input)
        {
            return new AngleValue(input, AngleUnit.Grad);
        }

        public static AngleValue Grad(this int input)
        {
            return new AngleValue(input, AngleUnit.Grad);
        }

        public static AngleValue Turn(this double input)
        {
            return new AngleValue(input, AngleUnit.Turn);
        }

        public static AngleValue Turn(this int input)
        {
            return new AngleValue(input, AngleUnit.Turn);
        }
    }
}
