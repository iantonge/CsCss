﻿namespace CsCss.Values.Calc
{
    public sealed class CalcProduct<T> : CalcValue<T> where T : Value
    {
        public CalcProduct(string v) : base(v)
        {
        }

        public static CalcSum<T> operator +(CalcProduct<T> a, CalcSum<T> b)
            => new CalcSum<T>(a.ToString() + " + " + b.ToString());

        public static CalcSum<T> operator +(CalcProduct<T> a, CalcProduct<T> b)
            => new CalcSum<T>(a.ToString() + " + " + b.ToString());

        public static CalcSum<T> operator -(CalcProduct<T> a, CalcSum<T> b)
            => new CalcSum<T>(a.ToString() + " - " + b.ToString());

        public static CalcSum<T> operator -(CalcProduct<T> a, CalcProduct<T> b)
            => new CalcSum<T>(a.ToString() + " - " + b.ToString());

        public static CalcProduct<T> operator *(int a, CalcProduct<T> b)
            => new CalcProduct<T>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<T> operator *(double a, CalcProduct<T> b)
            => new CalcProduct<T>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<T> operator *(CalcProduct<T> a, int b)
            => new CalcProduct<T>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<T> operator *(CalcProduct<T> a, double b)
            => new CalcProduct<T>(a.ToString() + " * " + b.ToString());

        public static CalcProduct<T> operator /(CalcProduct<T> a, int b)
            => new CalcProduct<T>(a.ToString() + " / " + b.ToString());

        public static CalcProduct<T> operator /(CalcProduct<T> a, double b)
            => new CalcProduct<T>(a.ToString() + " / " + b.ToString());
    }
}
