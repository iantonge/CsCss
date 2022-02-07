using CsCss.Values.Numeric.AnglePercentage;
using CsCss.Values.Numeric.Calc;
using CsCss.Values.Numeric.Percentage;

namespace CsCss.Values.Numeric.Angle
{
    public sealed class AngleValue : NumericValue
    {
        internal AngleValue(string v) : base(v) { }
        internal AngleValue(int number, AngleUnit unit) : base(number.ToString() + unit.ToString()) { }
        internal AngleValue(double number, AngleUnit unit) : base(number.ToString() + unit.ToString()) { }

        public static CalcSum<AngleValue> operator +(AngleValue a, AngleValue b)
            => new CalcSum<AngleValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator +(AngleValue a, PercentageValue b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<AngleValue> operator +(AngleValue a, CalcSum<AngleValue> b)
            => new CalcSum<AngleValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator +(AngleValue a, CalcSum<PercentageValue> b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<AngleValue> operator +(AngleValue a, CalcProduct<AngleValue> b)
            => new CalcSum<AngleValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator +(AngleValue a, CalcProduct<PercentageValue> b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator +(PercentageValue a, AngleValue b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<AngleValue> operator +(CalcSum<AngleValue> a, AngleValue b)
            => new CalcSum<AngleValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator +(CalcSum<PercentageValue> a, AngleValue b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<AngleValue> operator +(CalcProduct<AngleValue> a, AngleValue b)
            => new CalcSum<AngleValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator +(CalcProduct<PercentageValue> a, AngleValue b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<AngleValue> operator -(AngleValue a, AngleValue b)
            => new CalcSum<AngleValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator -(AngleValue a, PercentageValue b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<AngleValue> operator -(AngleValue a, CalcSum<AngleValue> b)
            => new CalcSum<AngleValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator -(AngleValue a, CalcSum<PercentageValue> b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<AngleValue> operator -(AngleValue a, CalcProduct<AngleValue> b)
            => new CalcSum<AngleValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator -(AngleValue a, CalcProduct<PercentageValue> b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator -(PercentageValue a, AngleValue b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<AngleValue> operator -(CalcSum<AngleValue> a, AngleValue b)
            => new CalcSum<AngleValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator -(CalcSum<PercentageValue> a, AngleValue b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<AngleValue> operator -(CalcProduct<AngleValue> a, AngleValue b)
            => new CalcSum<AngleValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator -(CalcProduct<PercentageValue> a, AngleValue b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcProduct<AngleValue> operator *(AngleValue a, int b)
            => new CalcProduct<AngleValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<AngleValue> operator *(AngleValue a, double b)
            => new CalcProduct<AngleValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<AngleValue> operator *(int a, AngleValue b)
            => new CalcProduct<AngleValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<AngleValue> operator *(double a, AngleValue b)
            => new CalcProduct<AngleValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<AngleValue> operator /(AngleValue a, int b)
            => new CalcProduct<AngleValue>(a.ToString() + " / " + b.ToString());

        public static CalcProduct<AngleValue> operator /(AngleValue a, double b)
            => new CalcProduct<AngleValue>(a.ToString() + " / " + b.ToString());
    }
}
