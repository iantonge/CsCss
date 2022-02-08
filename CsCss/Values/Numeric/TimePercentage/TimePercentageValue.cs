using CsCss.Values.Numeric.Calc;
using CsCss.Values.Numeric.Percentage;
using CsCss.Values.Numeric.Time;

namespace CsCss.Values.Numeric.TimePercentage
{
    public class TimePercentageValue : NumericValue
    {
        internal TimePercentageValue(string v) : base(v) { }

        public static implicit operator TimePercentageValue(TimeValue value)
        {
            return new TimePercentageValue(value.ToString());
        }

        public static implicit operator TimePercentageValue(PercentageValue value)
        {
            return new TimePercentageValue(value.ToString());
        }

        public static CalcSum<TimePercentageValue> operator +(TimePercentageValue a, TimePercentageValue b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimePercentageValue> operator +(TimePercentageValue a, CalcSum<TimePercentageValue> b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimePercentageValue> operator +(TimePercentageValue a, CalcProduct<TimePercentageValue> b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimePercentageValue> operator +(CalcSum<TimePercentageValue> a, TimePercentageValue b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimePercentageValue> operator +(CalcProduct<TimePercentageValue> a, TimePercentageValue b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimePercentageValue> operator -(TimePercentageValue a, TimePercentageValue b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimePercentageValue> operator -(TimePercentageValue a, CalcSum<TimePercentageValue> b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimePercentageValue> operator -(TimePercentageValue a, CalcProduct<TimePercentageValue> b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimePercentageValue> operator -(CalcSum<TimePercentageValue> a, TimePercentageValue b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimePercentageValue> operator -(CalcProduct<TimePercentageValue> a, TimePercentageValue b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcProduct<TimePercentageValue> operator *(TimePercentageValue a, int b)
            => new CalcProduct<TimePercentageValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<TimePercentageValue> operator *(TimePercentageValue a, double b)
            => new CalcProduct<TimePercentageValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<TimePercentageValue> operator *(int a, TimePercentageValue b)
            => new CalcProduct<TimePercentageValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<TimePercentageValue> operator *(double a, TimePercentageValue b)
            => new CalcProduct<TimePercentageValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<TimePercentageValue> operator /(TimePercentageValue a, int b)
            => new CalcProduct<TimePercentageValue>(a.ToString() + " / " + b.ToString());

        public static CalcProduct<TimePercentageValue> operator /(TimePercentageValue a, double b)
            => new CalcProduct<TimePercentageValue>(a.ToString() + " / " + b.ToString());
    }
}
