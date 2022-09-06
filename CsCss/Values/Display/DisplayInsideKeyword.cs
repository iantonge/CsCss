using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCss.Values.Display
{
    public sealed class DisplayInsideKeyword : Value
    {
        private DisplayInsideKeyword(string v) : base(v) { }

        internal static readonly DisplayInsideKeyword Flow = new DisplayInsideKeyword("flow");
        internal static readonly DisplayInsideKeyword FlowRoot = new DisplayInsideKeyword("flow-root");
        internal static readonly DisplayInsideKeyword Table = new DisplayInsideKeyword("table");
        internal static readonly DisplayInsideKeyword Flex = new DisplayInsideKeyword("flex");
        internal static readonly DisplayInsideKeyword Grid = new DisplayInsideKeyword("grid");
        internal static readonly DisplayInsideKeyword Ruby = new DisplayInsideKeyword("ruby");
    }
}
