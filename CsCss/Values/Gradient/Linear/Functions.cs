using CsCss.Values.Gradient.Linear;

namespace CsCss
{
    public static partial class Functions
    {
        public static ILinearGradientBuilder BuildLinearGradient()
        {
            return new LinearGradientBuilder("linear-gradient");
        }

        public static ILinearGradientBuilder BuildRepeatingLinearGradient()
        {
            return new LinearGradientBuilder("repeating-linear-gradient");
        }
    }
}
