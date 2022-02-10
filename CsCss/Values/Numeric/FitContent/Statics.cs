using CsCss.Values;
using CsCss.Values.Numeric.AnglePercentage;
using CsCss.Values.Numeric.FitContent;

namespace CsCss
{
    public static partial class Statics
    {
        public static FitContentValue FitContent(AnglePercentageValue calcValue)
        {
            return new FitContentValue("fit-content(" + calcValue.ToString() + ")");
        }
    }
}
