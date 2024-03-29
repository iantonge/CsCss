﻿namespace CsCss.Values.Calc
{
    public sealed class CalcSum<T> : CalcValue<T> where T : Value
    {
        public CalcSum(string v) : base(v) { }

        public static CalcSum<T> operator +(CalcSum<T> a, CalcProduct<T> b)
            => new CalcSum<T>(a.ToString() + " + " + b.ToString());

        public static CalcSum<T> operator +(CalcSum<T> a, CalcSum<T> b)
            => new CalcSum<T>(a.ToString() + " + " + b.ToString());

        public static CalcSum<T> operator -(CalcSum<T> a, CalcProduct<T> b)
            => new CalcSum<T>(a.ToString() + " - " + b.ToString());

        public static CalcSum<T> operator -(CalcSum<T> a, CalcSum<T> b)
            => new CalcSum<T>(a.ToString() + " - " + b.ToString());

        public static CalcProduct<T> operator *(int a, CalcSum<T> b)
            => new CalcProduct<T>(a.ToString() + " * (" + b.ToString() + ")");

        public static CalcProduct<T> operator *(double a, CalcSum<T> b)
            => new CalcProduct<T>(a.ToString() + " * (" + b.ToString() + ")");

        public static CalcProduct<T> operator *(CalcSum<T> a, int b)
            => new CalcProduct<T>("(" + a.ToString() + ") * " + b.ToString());

        public static CalcProduct<T> operator *(CalcSum<T> a, double b)
            => new CalcProduct<T>("(" + a.ToString() + ") * " + b.ToString());

        public static CalcProduct<T> operator /(CalcSum<T> a, int b)
            => new CalcProduct<T>("(" + a.ToString() + ") / " + b.ToString());

        public static CalcProduct<T> operator /(CalcSum<T> a, double b)
            => new CalcProduct<T>("(" + a.ToString() + ") / " + b.ToString());
    }
}
