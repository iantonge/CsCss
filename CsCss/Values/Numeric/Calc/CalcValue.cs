using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCss.Values.Numeric.Calc
{
    public abstract class CalcValue<T> : NumericValue where T : NumericValue
    {
        protected CalcValue(string v) : base(v)
        {
        }
    }
}
