using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCss.Values.Text.Keyword
{
    public sealed class FixedKeywordTextValue : KeywordTextValue
    {
        private FixedKeywordTextValue() : base("fixed") {}

        internal static readonly FixedKeywordTextValue Fixed = new FixedKeywordTextValue();
    }
}
