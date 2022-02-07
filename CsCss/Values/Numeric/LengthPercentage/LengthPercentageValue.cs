using CsCss.Values.Numeric.Calc;

namespace CsCss.Values.Numeric.LengthPercentage
{
    public class LengthPercentageValue : NumericValue
    {
        internal LengthPercentageValue(string v) : base(v) { }

        public static CalcSum<LengthPercentageValue> operator +(LengthPercentageValue a, LengthPercentageValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(LengthPercentageValue a, int b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(LengthPercentageValue a, double b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(LengthPercentageValue a, CalcSum<LengthPercentageValue> b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(LengthPercentageValue a, CalcProduct<LengthPercentageValue> b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(int a, LengthPercentageValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(double a, LengthPercentageValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(CalcSum<LengthPercentageValue> a, LengthPercentageValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(CalcProduct<LengthPercentageValue> a, LengthPercentageValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(LengthPercentageValue a, LengthPercentageValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(LengthPercentageValue a, int b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(LengthPercentageValue a, double b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(LengthPercentageValue a, CalcSum<LengthPercentageValue> b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(LengthPercentageValue a, CalcProduct<LengthPercentageValue> b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(int a, LengthPercentageValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(double a, LengthPercentageValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(CalcSum<LengthPercentageValue> a, LengthPercentageValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(CalcProduct<LengthPercentageValue> a, LengthPercentageValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcProduct<LengthPercentageValue> operator *(LengthPercentageValue a, int b)
            => new CalcProduct<LengthPercentageValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<LengthPercentageValue> operator *(LengthPercentageValue a, double b)
            => new CalcProduct<LengthPercentageValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<LengthPercentageValue> operator *(int a, LengthPercentageValue b)
            => new CalcProduct<LengthPercentageValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<LengthPercentageValue> operator *(double a, LengthPercentageValue b)
            => new CalcProduct<LengthPercentageValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<LengthPercentageValue> operator /(LengthPercentageValue a, int b)
            => new CalcProduct<LengthPercentageValue>(a.ToString() + " / " + b.ToString());

        public static CalcProduct<LengthPercentageValue> operator /(LengthPercentageValue a, double b)
            => new CalcProduct<LengthPercentageValue>(a.ToString() + " / " + b.ToString());
    }
}
