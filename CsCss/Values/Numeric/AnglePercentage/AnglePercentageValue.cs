using CsCss.Values.Numeric.Angle;
using CsCss.Values.Numeric.Calc;
using CsCss.Values.Numeric.Percentage;

namespace CsCss.Values.Numeric.AnglePercentage
{
    public class AnglePercentageValue : NumericValue
    {
        internal AnglePercentageValue(string v) : base(v) { }

        public static implicit operator AnglePercentageValue(AngleValue value)
        {
            return new AnglePercentageValue(value.ToString());
        }

        public static implicit operator AnglePercentageValue(PercentageValue value)
        {
            return new AnglePercentageValue(value.ToString());
        }

        public static CalcSum<AnglePercentageValue> operator +(AnglePercentageValue a, AnglePercentageValue b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator +(AnglePercentageValue a, CalcSum<AnglePercentageValue> b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator +(AnglePercentageValue a, CalcProduct<AnglePercentageValue> b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator +(CalcSum<AnglePercentageValue> a, AnglePercentageValue b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator +(CalcProduct<AnglePercentageValue> a, AnglePercentageValue b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator -(AnglePercentageValue a, AnglePercentageValue b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator -(AnglePercentageValue a, CalcSum<AnglePercentageValue> b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator -(AnglePercentageValue a, CalcProduct<AnglePercentageValue> b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator -(CalcSum<AnglePercentageValue> a, AnglePercentageValue b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator -(CalcProduct<AnglePercentageValue> a, AnglePercentageValue b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcProduct<AnglePercentageValue> operator *(AnglePercentageValue a, int b)
            => new CalcProduct<AnglePercentageValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<AnglePercentageValue> operator *(AnglePercentageValue a, double b)
            => new CalcProduct<AnglePercentageValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<AnglePercentageValue> operator *(int a, AnglePercentageValue b)
            => new CalcProduct<AnglePercentageValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<AnglePercentageValue> operator *(double a, AnglePercentageValue b)
            => new CalcProduct<AnglePercentageValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<AnglePercentageValue> operator /(AnglePercentageValue a, int b)
            => new CalcProduct<AnglePercentageValue>(a.ToString() + " / " + b.ToString());

        public static CalcProduct<AnglePercentageValue> operator /(AnglePercentageValue a, double b)
            => new CalcProduct<AnglePercentageValue>(a.ToString() + " / " + b.ToString());
    }
}
