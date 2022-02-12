using CsCss.Values.LengthPercentage;

namespace CsCss.Values.Gradient
{
    internal class TransitionHint : ColorStopItem
    {
        public TransitionHint(LengthPercentageValue value) : base(value.ToString()) { }
    }
}
