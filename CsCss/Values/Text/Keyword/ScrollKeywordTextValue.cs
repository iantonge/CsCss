using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCss.Values.Text.Keyword
{
    public sealed class ScrollKeywordTextValue : KeywordTextValue
    {
        private ScrollKeywordTextValue() : base("scroll") {}

        internal static readonly ScrollKeywordTextValue Scroll = new ScrollKeywordTextValue();
    }
}
