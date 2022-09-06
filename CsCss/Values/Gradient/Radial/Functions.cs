using CsCss.Values.Gradient.Radial;

namespace CsCss
{
    public static partial class Functions
    {
        public static IRadialGradientBuilder BuildRadialGradient()
        {
            return new RadialGradientBuilder("radial-gradient");
        }

        public static IRadialGradientBuilder BuildRepeatingRadialGradient()
        {
            return new RadialGradientBuilder("repeating-radial-gradient");
        }
    }
}
