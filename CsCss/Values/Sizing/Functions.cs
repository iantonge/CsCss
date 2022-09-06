using CsCss.Values.AnglePercentage;
using CsCss.Values.Sizing;

namespace CsCss
{
    public static partial class Functions
    {
        public static FitContentValue FitContent(AnglePercentageValue calcValue)
        {
            return new FitContentValue("fit-content(" + calcValue.ToString() + ")");
        }
    }
}