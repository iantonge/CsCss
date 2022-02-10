using CsCss.Values.Angle;
using CsCss.Values.AnglePercentage;
using CsCss.Values.Calc;
using CsCss.Values.Length;
using CsCss.Values.LengthPercentage;
using CsCss.Values.Time;
using CsCss.Values.TimePercentage;

namespace CsCss.Values.Percentage
{
    public sealed class PercentageValue : Value
    {
        internal PercentageValue(string v) : base(v) { }
        internal PercentageValue(int number, PercentageUnit unit) : base(number.ToString() + unit.ToString()) { }
        internal PercentageValue(double number, PercentageUnit unit) : base(number.ToString() + unit.ToString()) { }

        public static CalcSum<PercentageValue> operator +(PercentageValue a, PercentageValue b)
            => new CalcSum<PercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<PercentageValue> operator +(PercentageValue a, CalcSum<PercentageValue> b)
            => new CalcSum<PercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(PercentageValue a, CalcSum<LengthValue> b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator +(PercentageValue a, CalcSum<AngleValue> b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimePercentageValue> operator +(PercentageValue a, CalcSum<TimeValue> b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<PercentageValue> operator +(PercentageValue a, CalcProduct<PercentageValue> b)
            => new CalcSum<PercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(PercentageValue a, CalcProduct<LengthValue> b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator +(PercentageValue a, CalcProduct<AngleValue> b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimePercentageValue> operator +(PercentageValue a, CalcProduct<TimeValue> b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<PercentageValue> operator +(CalcSum<PercentageValue> a, PercentageValue b)
            => new CalcSum<PercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(CalcSum<LengthValue> a, PercentageValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator +(CalcSum<AngleValue> a, PercentageValue b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimePercentageValue> operator +(CalcSum<TimeValue> a, PercentageValue b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<PercentageValue> operator +(CalcProduct<PercentageValue> a, PercentageValue b)
            => new CalcSum<PercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(CalcProduct<LengthValue> a, PercentageValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator +(CalcProduct<AngleValue> a, PercentageValue b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<TimePercentageValue> operator +(CalcProduct<TimeValue> a, PercentageValue b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<PercentageValue> operator -(PercentageValue a, PercentageValue b)
            => new CalcSum<PercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<PercentageValue> operator -(PercentageValue a, CalcSum<PercentageValue> b)
            => new CalcSum<PercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(PercentageValue a, CalcSum<LengthValue> b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator -(PercentageValue a, CalcSum<AngleValue> b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimePercentageValue> operator -(PercentageValue a, CalcSum<TimeValue> b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<PercentageValue> operator -(PercentageValue a, CalcProduct<PercentageValue> b)
            => new CalcSum<PercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(PercentageValue a, CalcProduct<LengthValue> b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator -(PercentageValue a, CalcProduct<AngleValue> b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimePercentageValue> operator -(PercentageValue a, CalcProduct<TimeValue> b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<PercentageValue> operator -(CalcSum<PercentageValue> a, PercentageValue b)
            => new CalcSum<PercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(CalcSum<LengthValue> a, PercentageValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator -(CalcSum<AngleValue> a, PercentageValue b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimePercentageValue> operator -(CalcSum<TimeValue> a, PercentageValue b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<PercentageValue> operator -(CalcProduct<PercentageValue> a, PercentageValue b)
            => new CalcSum<PercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(CalcProduct<LengthValue> a, PercentageValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<AnglePercentageValue> operator -(CalcProduct<AngleValue> a, PercentageValue b)
            => new CalcSum<AnglePercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<TimePercentageValue> operator -(CalcProduct<TimeValue> a, PercentageValue b)
            => new CalcSum<TimePercentageValue>(a.ToString() + " - " + b.ToString());

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
