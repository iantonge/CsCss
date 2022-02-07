﻿using CsCss.Values.Numeric.Angle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCss.Values.Color.Hsl
{
    public sealed class HueValue
    {
        private readonly string value;

        private HueValue(string v)
        {
            value = v;
        }

        public override string ToString()
        {
            return value;
        }

        public static implicit operator HueValue(int value)
        {
            return new HueValue(value.ToString());
        }

        public static implicit operator HueValue(double value)
        {
            return new HueValue(value.ToString());
        }

        public static implicit operator HueValue(AngleValue value)
        {
            return new HueValue(value.ToString());
        }
    }
}
