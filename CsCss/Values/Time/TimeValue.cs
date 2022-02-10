using CsCss.Values.Calc;
using CsCss.Values.Percentage;
using CsCss.Values.TimePercentage;

namespace CsCss.Values.Time
{
    public sealed class TimeValue : Value
    {
        internal TimeValue(string v) : base(v) { }
        internal TimeValue(int number, TimeUnit unit) : base(number.ToString() + unit.ToString()) { }
        internal TimeValue(double  number, TimeUnit unit) : base(number.ToString() + unit.ToString()) { }

        public static CalcSum<TimeValue> operator +(TimeValue a, TimeValue b)
            => new CalcSum<TimeValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimePercentageValue> operator +(TimeValue a, PercentageValue b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimeValue> operator +(TimeValue a, CalcSum<TimeValue> b)
            => new CalcSum<TimeValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimePercentageValue> operator +(TimeValue a, CalcSum<PercentageValue> b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimePercentageValue> operator +(TimeValue a, CalcSum<TimePercentageValue> b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimeValue> operator +(TimeValue a, CalcProduct<TimeValue> b)
            => new CalcSum<TimeValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimePercentageValue> operator +(TimeValue a, CalcProduct<PercentageValue> b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimePercentageValue> operator +(TimeValue a, CalcProduct<TimePercentageValue> b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimePercentageValue> operator +(PercentageValue a, TimeValue b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimeValue> operator +(CalcSum<TimeValue> a, TimeValue b)
            => new CalcSum<TimeValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimePercentageValue> operator +(CalcSum<PercentageValue> a, TimeValue b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimePercentageValue> operator +(CalcSum<TimePercentageValue> a, TimeValue b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimeValue> operator +(CalcProduct<TimeValue> a, TimeValue b)
            => new CalcSum<TimeValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimePercentageValue> operator +(CalcProduct<PercentageValue> a, TimeValue b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimePercentageValue> operator +(CalcProduct<TimePercentageValue> a, TimeValue b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimeValue> operator -(TimeValue a, TimeValue b)
            => new CalcSum<TimeValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimePercentageValue> operator -(TimeValue a, PercentageValue b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimeValue> operator -(TimeValue a, CalcSum<TimeValue> b)
            => new CalcSum<TimeValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimePercentageValue> operator -(TimeValue a, CalcSum<PercentageValue> b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimePercentageValue> operator -(TimeValue a, CalcSum<TimePercentageValue> b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimeValue> operator -(TimeValue a, CalcProduct<TimeValue> b)
            => new CalcSum<TimeValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimePercentageValue> operator -(TimeValue a, CalcProduct<PercentageValue> b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimePercentageValue> operator -(TimeValue a, CalcProduct<TimePercentageValue> b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimePercentageValue> operator -(PercentageValue a, TimeValue b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimeValue> operator -(CalcSum<TimeValue> a, TimeValue b)
            => new CalcSum<TimeValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimePercentageValue> operator -(CalcSum<PercentageValue> a, TimeValue b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimePercentageValue> operator -(CalcSum<TimePercentageValue> a, TimeValue b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimeValue> operator -(CalcProduct<TimeValue> a, TimeValue b)
            => new CalcSum<TimeValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimePercentageValue> operator -(CalcProduct<PercentageValue> a, TimeValue b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimePercentageValue> operator -(CalcProduct<TimePercentageValue> a, TimeValue b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcProduct<TimeValue> operator *(TimeValue a, int b)
            => new CalcProduct<TimeValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<TimeValue> operator *(TimeValue a, double  b)
            => new CalcProduct<TimeValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<TimeValue> operator *(int a, TimeValue b)
            => new CalcProduct<TimeValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<TimeValue> operator *(double  a, TimeValue b)
            => new CalcProduct<TimeValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<TimeValue> operator /(TimeValue a, int b)
            => new CalcProduct<TimeValue>(a.ToString() + " / " + b.ToString());

        public static CalcProduct<TimeValue> operator /(TimeValue a, double  b)
            => new CalcProduct<TimeValue>(a.ToString() + " / " + b.ToString());
    }
}
