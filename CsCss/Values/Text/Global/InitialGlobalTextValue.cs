using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCss.Values.Text.Global
{
    public sealed class InitialGlobalTextValue : GlobalTextValue
    {
        private InitialGlobalTextValue() : base("initial") {}

        internal static readonly InitialGlobalTextValue Initial = new InitialGlobalTextValue();
    }
}
