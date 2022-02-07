using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCss.Values.Text
{
    public abstract class TextValue : Value
    {
        protected TextValue(string v) : base(v)
        {
        }
    }
}
