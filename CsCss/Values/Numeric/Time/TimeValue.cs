using CsCss.Values.Numeric.Calc;

namespace CsCss.Values.Numeric.Time
{
    public sealed class TimeValue : NumericValue
    {
        internal TimeValue(string v) : base(v) { }
        internal TimeValue(int number, TimeUnit unit) : base(number.ToString() + unit.ToString()) { }
        internal TimeValue(double  number, TimeUnit unit) : base(number.ToString() + unit.ToString()) { }

        public static CalcSum<TimeValue> operator +(TimeValue a, TimeValue b)
            => new CalcSum<TimeValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimeValue> operator +(TimeValue a, int b)
            => new CalcSum<TimeValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimeValue> operator +(TimeValue a, double  b)
            => new CalcSum<TimeValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimeValue> operator +(TimeValue a, CalcSum<TimeValue> b)
            => new CalcSum<TimeValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimeValue> operator +(TimeValue a, CalcProduct<TimeValue> b)
            => new CalcSum<TimeValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimeValue> operator +(int a, TimeValue b)
            => new CalcSum<TimeValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimeValue> operator +(double  a, TimeValue b)
            => new CalcSum<TimeValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimeValue> operator +(CalcSum<TimeValue> a, TimeValue b)
            => new CalcSum<TimeValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimeValue> operator +(CalcProduct<TimeValue> a, TimeValue b)
            => new CalcSum<TimeValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimeValue> operator -(TimeValue a, TimeValue b)
            => new CalcSum<TimeValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimeValue> operator -(TimeValue a, int b)
            => new CalcSum<TimeValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimeValue> operator -(TimeValue a, double  b)
            => new CalcSum<TimeValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimeValue> operator -(TimeValue a, CalcSum<TimeValue> b)
            => new CalcSum<TimeValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimeValue> operator -(TimeValue a, CalcProduct<TimeValue> b)
            => new CalcSum<TimeValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimeValue> operator -(int a, TimeValue b)
            => new CalcSum<TimeValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimeValue> operator -(double  a, TimeValue b)
            => new CalcSum<TimeValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimeValue> operator -(CalcSum<TimeValue> a, TimeValue b)
            => new CalcSum<TimeValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimeValue> operator -(CalcProduct<TimeValue> a, TimeValue b)
            => new CalcSum<TimeValue>(a.ToString() + " - " + b.ToString());

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
