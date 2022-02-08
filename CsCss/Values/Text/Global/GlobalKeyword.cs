using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCss.Values.Text.Global
{
    public abstract class GlobalKeyword : TextValue
    {
        protected GlobalKeyword(string v) : base(v)
        {
        }
    }
}
