using CsCss.Properties.Color;
using CsCss.Values.LengthPercentage;
using System.Collections.Immutable;
using System.Text;

namespace CsCss.Values.Gradient.Linear
{
    public interface ILinearGradientBuilder
    {
        GradientValue Build();
        ILinearGradientBuilder WithDirection(LinearGradientDirection direction);
        ILinearGradientBuilder WithColorStop(ColorValue color);
        ILinearGradientBuilder WithColorStop(ColorValue color, LengthPercentageValue from);
        ILinearGradientBuilder WithColorStop(ColorValue color, LengthPercentageValue from, LengthPercentageValue to);
        ILinearGradientBuilder WithTransitionHint(LengthPercentageValue hint);
    }

    public sealed record LinearGradientBuilder : ILinearGradientBuilder
    {
        private string function { get; init; }
        private LinearGradientDirection? direction { get; init; }
        private ImmutableList<LinearColorStopItem> colorStopList { get; init; }

        internal LinearGradientBuilder(string function)
        {
            this.function = function;
            this.colorStopList = ImmutableList<LinearColorStopItem>.Empty;
        }

        public ILinearGradientBuilder WithDirection(LinearGradientDirection direction)
        {
            return this with
            {
                direction = direction
            };
        }

        public ILinearGradientBuilder WithColorStop(ColorValue color)
        {
            return this with
            {
                colorStopList = colorStopList.Add(new LinearColorStop(color))
            };
        }

        public ILinearGradientBuilder WithColorStop(ColorValue color, LengthPercentageValue from)
        {
            return this with
            {
                colorStopList = colorStopList.Add(new LinearColorStop(color, from))
            };
        }

        public ILinearGradientBuilder WithColorStop(ColorValue color, LengthPercentageValue from, LengthPercentageValue to)
        {
            return this with
            {
                colorStopList = colorStopList.Add(new LinearColorStop(color, from, to))
            };
        }

        public ILinearGradientBuilder WithTransitionHint(LengthPercentageValue hint)
        {
            var lastColorStop = this.colorStopList.LastOrDefault();
            if (lastColorStop is null or LinearTransitionHint) throw new InvalidOperationException("Transistion hints must immediately follow a color stop");
            return this with
            {
                colorStopList = colorStopList.Add(new LinearTransitionHint(hint))
            };
        }

        public GradientValue Build()
        {
            var lastColorStop = this.colorStopList.LastOrDefault();
            if (lastColorStop is LinearTransitionHint) throw new InvalidOperationException("Transistion hints must be immediately followed by a color stop");
            var sb = new StringBuilder();
            sb.Append(function);
            sb.Append("(");
            if (direction is not null)
            {
                sb.Append(direction);
                sb.Append(",");
            }
            foreach (var colorStop in colorStopList)
            {
                sb.Append(colorStop.ToString());
                sb.Append(",");
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Append(")");
            return new GradientValue(sb.ToString());
        }
    }
}
