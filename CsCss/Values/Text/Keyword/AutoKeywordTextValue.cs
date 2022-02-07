using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCss.Values.Text.Keyword
{
    public sealed class AutoKeywordTextValue : KeywordTextValue
    {
        private AutoKeywordTextValue() : base("auto")
        {
        }

        internal static readonly AutoKeywordTextValue Auto = new AutoKeywordTextValue();
    }
}
