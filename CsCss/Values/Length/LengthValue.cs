﻿using CsCss.Values.Calc;
using CsCss.Values.LengthPercentage;
using CsCss.Values.Percentage;

namespace CsCss.Values.Length
{
    public sealed class LengthValue : Value
    {
        internal LengthValue(string v) : base(v) { }
        internal LengthValue(int number, LengthUnit unit) : base(number.ToString() + unit.ToString()) { }
        internal LengthValue(double number, LengthUnit unit) : base(number.ToString() + unit.ToString()) { }

        public static CalcSum<LengthValue> operator +(LengthValue a, LengthValue b)
            => new CalcSum<LengthValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(LengthValue a, PercentageValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthValue> operator +(LengthValue a, CalcSum<LengthValue> b)
            => new CalcSum<LengthValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(LengthValue a, CalcSum<PercentageValue> b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(LengthValue a, CalcSum<LengthPercentageValue> b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthValue> operator +(LengthValue a, CalcProduct<LengthValue> b)
            => new CalcSum<LengthValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(LengthValue a, CalcProduct<PercentageValue> b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(LengthValue a, CalcProduct<LengthPercentageValue> b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(PercentageValue a, LengthValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthValue> operator +(CalcSum<LengthValue> a, LengthValue b)
            => new CalcSum<LengthValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(CalcSum<PercentageValue> a, LengthValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(CalcSum<LengthPercentageValue> a, LengthValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthValue> operator +(CalcProduct<LengthValue> a, LengthValue b)
            => new CalcSum<LengthValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(CalcProduct<PercentageValue> a, LengthValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator +(CalcProduct<LengthPercentageValue> a, LengthValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " + " + b.ToString());

        public static CalcSum<LengthValue> operator -(LengthValue a, LengthValue b)
            => new CalcSum<LengthValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(LengthValue a, PercentageValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthValue> operator -(LengthValue a, CalcSum<LengthValue> b)
            => new CalcSum<LengthValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(LengthValue a, CalcSum<PercentageValue> b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(LengthValue a, CalcSum<LengthPercentageValue> b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthValue> operator -(LengthValue a, CalcProduct<LengthValue> b)
            => new CalcSum<LengthValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(LengthValue a, CalcProduct<PercentageValue> b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(LengthValue a, CalcProduct<LengthPercentageValue> b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(PercentageValue a, LengthValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthValue> operator -(CalcSum<LengthValue> a, LengthValue b)
            => new CalcSum<LengthValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(CalcSum<PercentageValue> a, LengthValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(CalcSum<LengthPercentageValue> a, LengthValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthValue> operator -(CalcProduct<LengthValue> a, LengthValue b)
            => new CalcSum<LengthValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(CalcProduct<PercentageValue> a, LengthValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

        public static CalcSum<LengthPercentageValue> operator -(CalcProduct<LengthPercentageValue> a, LengthValue b)
            => new CalcSum<LengthPercentageValue>(a.ToString() + " - " + b.ToString());

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
