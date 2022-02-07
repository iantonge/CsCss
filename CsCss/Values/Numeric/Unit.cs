using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCss.Values.Numeric
{
    public abstract class Unit
    {
        private readonly string unit;

        protected Unit(string u)
        {
            unit = u;
        }

        public override string ToString()
        {
            return unit;
        }
    }
}
