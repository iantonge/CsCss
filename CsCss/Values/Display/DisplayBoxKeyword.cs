using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCss.Values.Display
{
    public sealed class DisplayBoxKeyword : Value
    {
        private DisplayBoxKeyword(string v) : base(v) { }

        internal static readonly DisplayBoxKeyword Contents = new DisplayBoxKeyword("contents");
    }
}
