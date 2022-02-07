using CsCss.Values.Numeric.Calc;

namespace CsCss.Values.Numeric.Frequency
{
    public sealed class FrequencyValue : NumericValue
    {
        internal FrequencyValue(string v) : base(v) { }
        internal FrequencyValue(int number, FrequencyUnit unit) : base(number.ToString() + unit.ToString()) { }
        internal FrequencyValue(double number, FrequencyUnit unit) : base(number.ToString() + unit.ToString()) { }

        public static CalcSum<FrequencyValue> operator +(FrequencyValue a, FrequencyValue b)
            => new CalcSum<FrequencyValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<FrequencyValue> operator +(FrequencyValue a, int b)
            => new CalcSum<FrequencyValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<FrequencyValue> operator +(FrequencyValue a, double  b)
            => new CalcSum<FrequencyValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<FrequencyValue> operator +(FrequencyValue a, CalcSum<FrequencyValue> b)
            => new CalcSum<FrequencyValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<FrequencyValue> operator +(FrequencyValue a, CalcProduct<FrequencyValue> b)
            => new CalcSum<FrequencyValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<FrequencyValue> operator +(int a, FrequencyValue b)
            => new CalcSum<FrequencyValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<FrequencyValue> operator +(double  a, FrequencyValue b)
            => new CalcSum<FrequencyValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<FrequencyValue> operator +(CalcSum<FrequencyValue> a, FrequencyValue b)
            => new CalcSum<FrequencyValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<FrequencyValue> operator +(CalcProduct<FrequencyValue> a, FrequencyValue b)
            => new CalcSum<FrequencyValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<FrequencyValue> operator -(FrequencyValue a, FrequencyValue b)
            => new CalcSum<FrequencyValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<FrequencyValue> operator -(FrequencyValue a, int b)
            => new CalcSum<FrequencyValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<FrequencyValue> operator -(FrequencyValue a, double  b)
            => new CalcSum<FrequencyValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<FrequencyValue> operator -(FrequencyValue a, CalcSum<FrequencyValue> b)
            => new CalcSum<FrequencyValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<FrequencyValue> operator -(FrequencyValue a, CalcProduct<FrequencyValue> b)
            => new CalcSum<FrequencyValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<FrequencyValue> operator -(int a, FrequencyValue b)
            => new CalcSum<FrequencyValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<FrequencyValue> operator -(double  a, FrequencyValue b)
            => new CalcSum<FrequencyValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<FrequencyValue> operator -(CalcSum<FrequencyValue> a, FrequencyValue b)
            => new CalcSum<FrequencyValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<FrequencyValue> operator -(CalcProduct<FrequencyValue> a, FrequencyValue b)
            => new CalcSum<FrequencyValue>(a.ToString() + " - " + b.ToString());

        public static CalcProduct<FrequencyValue> operator *(FrequencyValue a, int b)
            => new CalcProduct<FrequencyValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<FrequencyValue> operator *(FrequencyValue a, double  b)
            => new CalcProduct<FrequencyValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<FrequencyValue> operator *(int a, FrequencyValue b)
            => new CalcProduct<FrequencyValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<FrequencyValue> operator *(double  a, FrequencyValue b)
            => new CalcProduct<FrequencyValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<FrequencyValue> operator /(FrequencyValue a, int b)
            => new CalcProduct<FrequencyValue>(a.ToString() + " / " + b.ToString());

        public static CalcProduct<FrequencyValue> operator /(FrequencyValue a, double  b)
            => new CalcProduct<FrequencyValue>(a.ToString() + " / " + b.ToString());
    }
}
