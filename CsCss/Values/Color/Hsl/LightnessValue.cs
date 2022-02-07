using CsCss.Values.Numeric.Percentage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCss.Values.Color.Hsl
{
    public sealed class LightnessValue
    {
        private readonly string value;

        private LightnessValue(string v)
        {
            value = v;
        }

        public override string ToString()
        {
            return value;
        }

        public static implicit operator LightnessValue(PercentageValue value)
        {
            return new LightnessValue(value.ToString());
        }
    }
}
