using CsCss.Values.Color;
using CsCss.Values.Color.Hwb;

namespace CsCss
{
    public static partial class Statics
    {
        public static HwbValue Hwb(HueValue hue, WhitenessValue whiteness, BlacknessValue blackness, AlphaValue? alpha = null)
        {
            return new HwbValue(hue, whiteness, blackness, alpha);
        }
    }
}
