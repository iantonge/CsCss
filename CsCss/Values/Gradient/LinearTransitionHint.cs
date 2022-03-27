using CsCss.Values.LengthPercentage;

namespace CsCss.Values.Gradient
{
    internal class LinearTransitionHint : LinearColorStopItem
    {
        public LinearTransitionHint(LengthPercentageValue value) : base(value.ToString()) { }
    }
}
