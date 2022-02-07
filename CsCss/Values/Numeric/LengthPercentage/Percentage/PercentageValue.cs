using CsCss.Values.Numeric.Calc;
using CsCss.Values.Numeric.LengthPercentage.Length;

namespace CsCss.Values.Numeric.LengthPercentage.Percentage
{
    public sealed class PercentageValue : LengthPercentageValue
    {
        internal PercentageValue(string v) : base(v) { }
        internal PercentageValue(int number, PercentageUnit unit) : base(number.ToString() + unit.ToString()) { }
        internal PercentageValue(double number, PercentageUnit unit) : base(number.ToString() + unit.ToString()) { }

        public static CalcSum<PercentageValue> operator +(PercentageValue a, PercentageValue b)
            => new CalcSum<PercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<PercentageValue> operator +(PercentageValue a, int b)
            => new CalcSum<PercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<PercentageValue> operator +(PercentageValue a, double b)
            => new CalcSum<PercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(PercentageValue a, LengthValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<PercentageValue> operator +(PercentageValue a, CalcSum<PercentageValue> b)
            => new CalcSum<PercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<PercentageValue> operator +(PercentageValue a, CalcProduct<PercentageValue> b)
            => new CalcSum<PercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(PercentageValue a, CalcSum<LengthValue> b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(PercentageValue a, CalcProduct<LengthValue> b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<PercentageValue> operator +(int a, PercentageValue b)
            => new CalcSum<PercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<PercentageValue> operator +(double a, PercentageValue b)
            => new CalcSum<PercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<PercentageValue> operator +(CalcSum<PercentageValue> a, PercentageValue b)
            => new CalcSum<PercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<PercentageValue> operator +(CalcProduct<PercentageValue> a, PercentageValue b)
            => new CalcSum<PercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<PercentageValue> operator -(PercentageValue a, PercentageValue b)
            => new CalcSum<PercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<PercentageValue> operator -(PercentageValue a, int b)
            => new CalcSum<PercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<PercentageValue> operator -(PercentageValue a, double b)
            => new CalcSum<PercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(PercentageValue a, LengthValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<PercentageValue> operator -(PercentageValue a, CalcSum<PercentageValue> b)
            => new CalcSum<PercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<PercentageValue> operator -(PercentageValue a, CalcProduct<PercentageValue> b)
            => new CalcSum<PercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(PercentageValue a, CalcSum<LengthValue> b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(PercentageValue a, CalcProduct<LengthValue> b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<PercentageValue> operator -(int a, PercentageValue b)
            => new CalcSum<PercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<PercentageValue> operator -(double a, PercentageValue b)
            => new CalcSum<PercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<PercentageValue> operator -(CalcSum<PercentageValue> a, PercentageValue b)
            => new CalcSum<PercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<PercentageValue> operator -(CalcProduct<PercentageValue> a, PercentageValue b)
            => new CalcSum<PercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcProduct<PercentageValue> operator *(PercentageValue a, int b)
            => new CalcProduct<PercentageValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<PercentageValue> operator *(PercentageValue a, double b)
            => new CalcProduct<PercentageValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<PercentageValue> operator *(int a, PercentageValue b)
            => new CalcProduct<PercentageValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<PercentageValue> operator *(double a, PercentageValue b)
            => new CalcProduct<PercentageValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<PercentageValue> operator /(PercentageValue a, int b)
            => new CalcProduct<PercentageValue>(a.ToString() + " / " + b.ToString());

        public static CalcProduct<PercentageValue> operator /(PercentageValue a, double b)
            => new CalcProduct<PercentageValue>(a.ToString() + " / " + b.ToString());
    }
}
