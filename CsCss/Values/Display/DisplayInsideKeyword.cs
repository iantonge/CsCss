using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCss.Values.Display;

public sealed class DisplayInsideKeyword : Value
{
    private DisplayInsideKeyword(string v) : base(v) { }

    internal static readonly DisplayInsideKeyword Flow = new("flow");
    internal static readonly DisplayInsideKeyword FlowRoot = new("flow-root");
    internal static readonly DisplayInsideKeyword Table = new("table");
    internal static readonly DisplayInsideKeyword Flex = new("flex");
    internal static readonly DisplayInsideKeyword Grid = new("grid");
    internal static readonly DisplayInsideKeyword Ruby = new("ruby");
}
