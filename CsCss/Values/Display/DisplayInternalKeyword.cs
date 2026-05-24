using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCss.Values.Display;

public sealed class DisplayInternalKeyword : Value
{
    private DisplayInternalKeyword(string v) : base(v) { }

    internal static readonly DisplayInternalKeyword TableRowGroup = new("table-row-group");
    internal static readonly DisplayInternalKeyword TableHeaderGroup = new("table-header-group");
    internal static readonly DisplayInternalKeyword TableFooterGroup = new("table-footer-group");
    internal static readonly DisplayInternalKeyword TableRow = new("table-row");
    internal static readonly DisplayInternalKeyword TableCell = new("table-cell");
    internal static readonly DisplayInternalKeyword TableColumnGroup = new("table-column-group");
    internal static readonly DisplayInternalKeyword TableColumn = new("table-column");
    internal static readonly DisplayInternalKeyword TableCaption = new("table-caption");
    internal static readonly DisplayInternalKeyword RubyBase = new("ruby-base");
    internal static readonly DisplayInternalKeyword RubyText = new("ruby-text");
    internal static readonly DisplayInternalKeyword RubyBaseContainer = new("ruby-base-container");
    internal static readonly DisplayInternalKeyword RubyTextContainer = new("ruby-text-container");
}
