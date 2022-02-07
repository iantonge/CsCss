using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCss.Values.Text.Global
{
    public sealed class UnsetGlobalTextValue : GlobalTextValue
    {
        private UnsetGlobalTextValue() : base("unset") {}

        internal static readonly UnsetGlobalTextValue Unset = new UnsetGlobalTextValue();
    }
}
