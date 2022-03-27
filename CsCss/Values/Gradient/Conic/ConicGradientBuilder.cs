using CsCss.Properties.Color;
using CsCss.Values.Angle;
using CsCss.Values.AnglePercentage;
using CsCss.Values.Position;
using System.Collections.Immutable;
using System.Text;

namespace CsCss.Values.Gradient.Conic
{
    public interface IConicGradientBuilder
    {
        IConicGradientBuilder FromAngle(AngleValue angle);
        IConicGradientBuilder AtPosition(PositionValue position);
        GradientValue Build();
        IConicGradientBuilder WithColorStop(ColorValue color);
        IConicGradientBuilder WithColorStop(ColorValue color, AnglePercentageValue from);
        IConicGradientBuilder WithColorStop(ColorValue color, AnglePercentageValue from, AnglePercentageValue to);
        IConicGradientBuilder WithTransitionHint(AnglePercentageValue hint);
    }

    public sealed record ConicGradientBuilder : IConicGradientBuilder
    {
        private string function { get; init; }
        private AngleValue? from { get; init; }
        private PositionValue? position { get; init; }
        private ImmutableList<AngularColorStopItem> colorStopList { get; init; }

        internal ConicGradientBuilder(string function)
        {
            this.function = function;
            this.colorStopList = ImmutableList<AngularColorStopItem>.Empty;
        }

        public IConicGradientBuilder FromAngle(AngleValue angle)
        {
            return this with
            {
                from = angle
            };
        }

        public IConicGradientBuilder AtPosition(PositionValue position)
        {
            return this with
            {
                position = position
            };
        }

        public IConicGradientBuilder WithColorStop(ColorValue color)
        {
            return this with
            {
                colorStopList = colorStopList.Add(new AngularColorStop(color))
            };
        }

        public IConicGradientBuilder WithColorStop(ColorValue color, AnglePercentageValue from)
        {
            return this with
            {
                colorStopList = colorStopList.Add(new AngularColorStop(color, from))
            };
        }

        public IConicGradientBuilder WithColorStop(ColorValue color, AnglePercentageValue from, AnglePercentageValue to)
        {
            return this with
            {
                colorStopList = colorStopList.Add(new AngularColorStop(color, from, to))
            };
        }

        public IConicGradientBuilder WithTransitionHint(AnglePercentageValue hint)
        {
            var lastColorStop = this.colorStopList.LastOrDefault();
            if (lastColorStop is null or AngularTransitionHint) throw new InvalidOperationException("Transistion hints must immediately follow a color stop");
            return this with
            {
                colorStopList = colorStopList.Add(new AngularTransitionHint(hint))
            };
        }

        public GradientValue Build()
        {
            if (colorStopList.Count < 2) throw new InvalidOperationException("Cannot build gradient with fewer than two color stops");
            var lastColorStop = this.colorStopList.Last();
            if (lastColorStop is AngularTransitionHint) throw new InvalidOperationException("Transistion hints must be immediately followed by a color stop");
            var sb = new StringBuilder();
            sb.Append(function);
            sb.Append("(");
            var gradientConfig = string.Join(" ", new string?[] {
                from is null ? null : "from " + from.ToString(),
                position is null ? null : "at " + position.ToString()
            }.Where(x => x is not null));
            if (!string.IsNullOrEmpty(gradientConfig))
            {
                sb.Append(gradientConfig + ",");
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
