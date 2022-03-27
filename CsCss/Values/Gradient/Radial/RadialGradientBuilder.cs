using CsCss.Properties.Color;
using CsCss.Values.Length;
using CsCss.Values.LengthPercentage;
using CsCss.Values.Position;
using System.Collections.Immutable;
using System.Text;

namespace CsCss.Values.Gradient.Radial
{
    public interface IRadialGradientBuilder
    {
        IRadialGradientBuilder AtPosition(PositionValue position);
        GradientValue Build();
        IRadialGradientBuilder Circular();
        IRadialGradientBuilder Circular(LengthValue radius);
        IRadialGradientBuilder Circular(RadialGradientSize size);
        IRadialGradientBuilder Eliptical();
        IRadialGradientBuilder Eliptical(LengthPercentageValue radius);
        IRadialGradientBuilder Eliptical(LengthPercentageValue horizontalRadius, LengthPercentageValue verticalRadius);
        IRadialGradientBuilder Eliptical(RadialGradientSize size);
        IRadialGradientBuilder WithColorStop(ColorValue color);
        IRadialGradientBuilder WithColorStop(ColorValue color, LengthPercentageValue from);
        IRadialGradientBuilder WithColorStop(ColorValue color, LengthPercentageValue from, LengthPercentageValue to);
        IRadialGradientBuilder WithTransitionHint(LengthPercentageValue hint);
    }

    public sealed record RadialGradientBuilder : IRadialGradientBuilder
    {
        private string function { get; init; }
        private RadialGradientShape? shape { get; init; }
        private RadialGradientSize? size { get; init; }
        private LengthValue? radius { get; init; }
        private LengthPercentageValue? horizontalRadius { get; init; }
        private LengthPercentageValue? verticalRadius { get; init; }
        private PositionValue? position { get; init; }
        private ImmutableList<LinearColorStopItem> colorStopList { get; init; }

        internal RadialGradientBuilder(string function)
        {
            this.function = function;
            this.colorStopList = ImmutableList<LinearColorStopItem>.Empty;
        }

        public IRadialGradientBuilder Circular()
        {
            return this with
            {
                shape = RadialGradientShape.Circle
            };
        }

        public IRadialGradientBuilder Circular(LengthValue radius)
        {
            return this with
            {
                shape = RadialGradientShape.Circle,
                radius = radius
            };
        }

        public IRadialGradientBuilder Circular(RadialGradientSize size)
        {
            return this with
            {
                shape = RadialGradientShape.Circle,
                size = size
            };
        }

        public IRadialGradientBuilder Eliptical()
        {
            return this with
            {
                shape = RadialGradientShape.Ellipse
            };
        }

        public IRadialGradientBuilder Eliptical(LengthPercentageValue radius)
        {
            return this with
            {
                shape = RadialGradientShape.Ellipse,
                horizontalRadius = radius
            };
        }

        public IRadialGradientBuilder Eliptical(LengthPercentageValue horizontalRadius, LengthPercentageValue verticalRadius)
        {
            return this with
            {
                shape = RadialGradientShape.Ellipse,
                horizontalRadius = horizontalRadius,
                verticalRadius = verticalRadius
            };
        }

        public IRadialGradientBuilder Eliptical(RadialGradientSize size)
        {
            return this with
            {
                shape = RadialGradientShape.Ellipse,
                size = size
            };
        }

        public IRadialGradientBuilder AtPosition(PositionValue position)
        {
            return this with
            {
                position = position
            };
        }

        public IRadialGradientBuilder WithColorStop(ColorValue color)
        {
            return this with
            {
                colorStopList = colorStopList.Add(new LinearColorStop(color))
            };
        }

        public IRadialGradientBuilder WithColorStop(ColorValue color, LengthPercentageValue from)
        {
            return this with
            {
                colorStopList = colorStopList.Add(new LinearColorStop(color, from))
            };
        }

        public IRadialGradientBuilder WithColorStop(ColorValue color, LengthPercentageValue from, LengthPercentageValue to)
        {
            return this with
            {
                colorStopList = colorStopList.Add(new LinearColorStop(color, from, to))
            };
        }

        public IRadialGradientBuilder WithTransitionHint(LengthPercentageValue hint)
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
            var gradientConfig = string.Join(" ", new string?[] {
                shape?.ToString(),
                size?.ToString(),
                radius?.ToString(),
                horizontalRadius?.ToString(),
                verticalRadius?.ToString(),
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
