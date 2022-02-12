﻿using CsCss.Values.Gradient;
using CsCss.Values.Url;

namespace CsCss.Values.Image
{
    public sealed class ImageValue : Value
    {
        internal ImageValue(string v) : base(v) { }

        public static implicit operator ImageValue(UrlValue value)
        {
            return new ImageValue(value.ToString());
        }

        public static implicit operator ImageValue(GradientValue value)
        {
            return new ImageValue(value.ToString());
        }
    }
}
