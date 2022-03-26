using CsCss.Properties.Color;
using CsCss.Values.Length;
using CsCss.Values.LengthPercentage;
using CsCss.Values.Position;
using System.Text;

namespace CsCss.Values.Gradient
{
    public sealed class RadialGradientBuilder
    {
        private readonly string function;
        private readonly RadialGradientShape? shape;
        private readonly RadialGradientSize? size;
        private readonly LengthValue? radius;
        private readonly LengthPercentageValue? horizontalRadius;
        private readonly LengthPercentageValue? verticalRadius;
        private readonly PositionValue? position;
        private List<ColorStopItem> colorStopList = new List<ColorStopItem>();

        internal RadialGradientBuilder(string function)
        {
            this.function = function;
        }

        private RadialGradientBuilder(string function, RadialGradientShape? shape, RadialGradientSize? size, LengthValue? radius, LengthPercentageValue? horizontalRadius, LengthPercentageValue? verticalRadius, PositionValue? position, List<ColorStopItem> parameters)
        {
            this.function = function;
            this.shape = shape;
            this.size = size;
            this.radius = radius;
            this.horizontalRadius = horizontalRadius;
            this.verticalRadius = verticalRadius;
            this.position = position;
            this.colorStopList = parameters;
        }

        public RadialGradientBuilder Circular()
        {
            return new RadialGradientBuilder(function, RadialGradientShape.Circle, size, radius, horizontalRadius, verticalRadius, position, colorStopList);
        }

        public RadialGradientBuilder Circular(LengthValue radius)
        {
            return new RadialGradientBuilder(function, RadialGradientShape.Circle, size, radius, horizontalRadius, verticalRadius, position, colorStopList);
        }

        public RadialGradientBuilder Circular(RadialGradientSize size)
        {
            return new RadialGradientBuilder(function, RadialGradientShape.Circle, size, radius, horizontalRadius, verticalRadius, position, colorStopList);
        }

        public RadialGradientBuilder Eliptical()
        {
            return new RadialGradientBuilder(function, RadialGradientShape.Ellipse, size, radius, horizontalRadius, verticalRadius, position, colorStopList);
        }

        public RadialGradientBuilder Eliptical(LengthPercentageValue radius)
        {
            return new RadialGradientBuilder(function, RadialGradientShape.Ellipse, size, this.radius, radius, verticalRadius, position, colorStopList);
        }

        public RadialGradientBuilder Eliptical(LengthPercentageValue horizontalRadius, LengthPercentageValue verticalRadius)
        {
            return new RadialGradientBuilder(function, RadialGradientShape.Ellipse, size, radius, horizontalRadius, verticalRadius, position, colorStopList);
        }

        public RadialGradientBuilder Eliptical(RadialGradientSize size)
        {
            return new RadialGradientBuilder(function, RadialGradientShape.Ellipse, size, radius, horizontalRadius, verticalRadius, position, colorStopList);
        }

        public RadialGradientBuilder AtPosition(PositionValue position)
        {
            return new RadialGradientBuilder(function, shape, size, radius, horizontalRadius, verticalRadius, position, colorStopList);
        }

        public RadialGradientBuilder WithColorStop(ColorValue color)
        {
            var newParameters = this.colorStopList.ToList();
            newParameters.Add(new ColorStop(color));
            return new RadialGradientBuilder(function, shape, size, radius, horizontalRadius, verticalRadius, position, newParameters);
        }

        public RadialGradientBuilder WithColorStop(ColorValue color, LengthPercentageValue from)
        {
            var newParameters = this.colorStopList.ToList();
            newParameters.Add(new ColorStop(color, from));
            return new RadialGradientBuilder(function, shape, size, radius, horizontalRadius, verticalRadius, position, newParameters);
        }

        public RadialGradientBuilder WithColorStop(ColorValue color, LengthPercentageValue from, LengthPercentageValue to)
        {
            var newParameters = this.colorStopList.ToList();
            newParameters.Add(new ColorStop(color, from, to));
            return new RadialGradientBuilder(function, shape, size, radius, horizontalRadius, verticalRadius, position, newParameters);
        }

        public RadialGradientBuilder WithTransitionHint(LengthPercentageValue hint)
        {
            var newParameters = this.colorStopList.ToList();
            var lastColorStop = this.colorStopList.LastOrDefault();
            if (lastColorStop is null or TransitionHint) throw new InvalidOperationException("Transistion hints must immediately follow color stop");
            newParameters.Add(new TransitionHint(hint));
            return new RadialGradientBuilder(function, shape, size, radius, horizontalRadius, verticalRadius, position, newParameters);
        }

        public GradientValue Build()
        {
            var lastColorStop = this.colorStopList.LastOrDefault();
            if (lastColorStop is TransitionHint) throw new InvalidOperationException("Transistion hints must be immediately followed by a color stop");
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
            foreach(var colorStop in colorStopList)
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
