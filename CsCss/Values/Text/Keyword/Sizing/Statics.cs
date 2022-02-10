using CsCss.Values.Numeric.AnglePercentage;
using CsCss.Values.Text.Keyword.Sizing;

namespace CsCss
{
    public static partial class Statics
    {
        public static readonly MaxContentKeyword MaxContent = MaxContentKeyword.MaxContent;
        public static readonly MinContentKeyword MinContent = MinContentKeyword.MinContent;
        // FitContent can be a both a function and a keyword. We'll have to represent the keyword as a
        // function without any arguments.
        public static FitContentKeyword FitContent() => FitContentKeyword.FitContent;
    }
}