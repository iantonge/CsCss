using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCss.Values.Text.Keyword
{
    public sealed class LocalKeywordTextValue : KeywordTextValue
    {
        private LocalKeywordTextValue() : base("local") {}

        internal static readonly LocalKeywordTextValue Local = new LocalKeywordTextValue();
    }
}
