using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCss.Values.Numeric
{
    public abstract class NumericValue : Value
    {
        protected NumericValue(string v) : base(v) { }
    }
}
