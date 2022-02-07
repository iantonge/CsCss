namespace CsCss.Values.Color.Hwb
{
    public sealed class HwbValue : ColorValue
    {
        internal HwbValue(HueValue hue, WhitenessValue whiteness, BlacknessValue blackness, AlphaValue? alpha)
            : base($"hwb(${hue},${whiteness},${blackness}${(alpha is null ? string.Empty : "," + alpha)})")
        {
        }
    }
}
