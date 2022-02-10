using CsCss.Values.AnglePercentage;
using CsCss.Values.Sizing;

namespace CsCss
{
    public static partial class Statics
    {
        public static readonly MaxContentKeyword MaxContent = MaxContentKeyword.MaxContent;
        public static readonly MinContentKeyword MinContent = MinContentKeyword.MinContent;
        // GOTCHA: FitContent can be a both a function and a keyword
        // We'll have to represent the keyword as a function without any arguments.
        public static FitContentKeyword FitContent() => FitContentKeyword.FitContent;

        public static FitContentValue FitContent(AnglePercentageValue calcValue)
        {
            return new FitContentValue("fit-content(" + calcValue.ToString() + ")");
        }
    }
}