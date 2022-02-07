using CsCss.Values.Numeric.Calc;
using CsCss.Values.Numeric.LengthPercentage.Percentage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCss.Values.Numeric.LengthPercentage.Length
{
    public sealed class LengthValue : LengthPercentageValue
    {
        internal LengthValue(string v) : base(v) { }
        internal LengthValue(int number, LengthUnit unit) : base(number.ToString() + unit.ToString()) { }
        internal LengthValue(double number, LengthUnit unit) : base(number.ToString() + unit.ToString()) { }

        public static CalcSum<LengthValue> operator +(LengthValue a, LengthValue b)
            => new CalcSum<LengthValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthValue> operator +(LengthValue a, int b)
            => new CalcSum<LengthValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthValue> operator +(LengthValue a, double b)
            => new CalcSum<LengthValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(LengthValue a, PercentageValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthValue> operator +(LengthValue a, CalcSum<LengthValue> b)
            => new CalcSum<LengthValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthValue> operator +(LengthValue a, CalcProduct<LengthValue> b)
            => new CalcSum<LengthValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(LengthValue a, CalcSum<PercentageValue> b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(LengthValue a, CalcProduct<PercentageValue> b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthValue> operator +(int a, LengthValue b)
            => new CalcSum<LengthValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthValue> operator +(double a, LengthValue b)
            => new CalcSum<LengthValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthValue> operator +(CalcSum<LengthValue> a, LengthValue b)
            => new CalcSum<LengthValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthValue> operator +(CalcProduct<LengthValue> a, LengthValue b)
            => new CalcSum<LengthValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthValue> operator -(LengthValue a, LengthValue b)
            => new CalcSum<LengthValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(LengthValue a, PercentageValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthValue> operator -(LengthValue a, int b)
            => new CalcSum<LengthValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthValue> operator -(LengthValue a, double b)
            => new CalcSum<LengthValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthValue> operator -(LengthValue a, CalcSum<LengthValue> b)
            => new CalcSum<LengthValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthValue> operator -(LengthValue a, CalcProduct<LengthValue> b)
            => new CalcSum<LengthValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(LengthValue a, CalcSum<PercentageValue> b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(LengthValue a, CalcProduct<PercentageValue> b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthValue> operator -(int a, LengthValue b)
            => new CalcSum<LengthValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthValue> operator -(double a, LengthValue b)
            => new CalcSum<LengthValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthValue> operator -(CalcSum<LengthValue> a, LengthValue b)
            => new CalcSum<LengthValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthValue> operator -(CalcProduct<LengthValue> a, LengthValue b)
            => new CalcSum<LengthValue>(a.ToString() + " - " + b.ToString());

        public static CalcProduct<LengthValue> operator *(LengthValue a, int b)
            => new CalcProduct<LengthValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<LengthValue> operator *(LengthValue a, double b)
            => new CalcProduct<LengthValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<LengthValue> operator *(int a, LengthValue b)
            => new CalcProduct<LengthValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<LengthValue> operator *(double a, LengthValue b)
            => new CalcProduct<LengthValue>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<LengthValue> operator /(LengthValue a, int b)
            => new CalcProduct<LengthValue>(a.ToString() + " / " + b.ToString());

        public static CalcProduct<LengthValue> operator /(LengthValue a, double b)
            => new CalcProduct<LengthValue>(a.ToString() + " / " + b.ToString());
    }
}
