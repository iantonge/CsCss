using CsCss.Values.LengthPercentage;

namespace CsCss.Values.Gradient
{
    internal class TransitionHint : GradientParameter
    {
        public TransitionHint(LengthPercentageValue value) : base(value.ToString()) { }
    }
}
