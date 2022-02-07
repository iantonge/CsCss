using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCss.Values.Text.String
{
    public class StringTextValue : TextValue
    {
        public StringTextValue(string v) : base($"'{v}'")
        {
        }
    }
}
