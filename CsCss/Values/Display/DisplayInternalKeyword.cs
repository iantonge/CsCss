using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCss.Values.Display
{
    public sealed class DisplayInternalKeyword : Value
    {
        private DisplayInternalKeyword(string v) : base(v) { }

        internal static readonly DisplayInternalKeyword TableRowGroup = new DisplayInternalKeyword("table-row-group");
        internal static readonly DisplayInternalKeyword TableHeaderGroup = new DisplayInternalKeyword("table-header-group");
        internal static readonly DisplayInternalKeyword TableFooterGroup = new DisplayInternalKeyword("table-footer-group");
        internal static readonly DisplayInternalKeyword TableRow = new DisplayInternalKeyword("table-row");
        internal static readonly DisplayInternalKeyword TableCell = new DisplayInternalKeyword("table-cell");
        internal static readonly DisplayInternalKeyword TableColumnGroup = new DisplayInternalKeyword("table-column-group");
        internal static readonly DisplayInternalKeyword TableColumn = new DisplayInternalKeyword("table-column");
        internal static readonly DisplayInternalKeyword TableCaption = new DisplayInternalKeyword("table-caption");
        internal static readonly DisplayInternalKeyword RubyBase = new DisplayInternalKeyword("ruby-base");
        internal static readonly DisplayInternalKeyword RubyText = new DisplayInternalKeyword("ruby-text");
        internal static readonly DisplayInternalKeyword RubyBaseContainer = new DisplayInternalKeyword("ruby-base-container");
        internal static readonly DisplayInternalKeyword RubyTextContainer = new DisplayInternalKeyword("ruby-text-container");
    }
}
