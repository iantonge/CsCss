using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCss.Values.Text.Global
{
    public sealed class InheritGlobalTextValue : GlobalTextValue
    {
        private InheritGlobalTextValue() : base("inherit") {}

        internal static readonly InheritGlobalTextValue Inherit = new InheritGlobalTextValue();
    }
}
