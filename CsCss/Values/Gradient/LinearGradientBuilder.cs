using CsCss.Properties.Color;
using CsCss.Values.LengthPercentage;
using System.Text;

namespace CsCss.Values.Gradient
{
    public interface ILinearGradientBuilderWithoutStops
    {
        ILinearGradientBuilderWithStop WithColorStop(ColorValue color);
    }

    public interface ILinearGradientBuilderWithStop
    {
        ILinearGradientBuilderWithStops WithColorStop(ColorValue color);
        ILinearGradientBuilderWithStops WithColorStop(ColorValue color, LengthPercentageValue from);
        ILinearGradientBuilderWithStops WithColorStop(ColorValue color, LengthPercentageValue from, LengthPercentageValue to);
        ILinearGradientBuilderWithUnclosedTransitionHint WithTransitionHint(LengthPercentageValue hint);
    }

    public interface ILinearGradientBuilderWithStops : ILinearGradientBuilderWithStop
    {
        GradientValue Build();
    }

    public interface ILinearGradientBuilderWithUnclosedTransitionHint
    {
        ILinearGradientBuilderWithStops WithColorStop(ColorValue color);
    }

    public sealed class LinearGradientBuilder : ILinearGradientBuilderWithoutStops, ILinearGradientBuilderWithStop, ILinearGradientBuilderWithStops, ILinearGradientBuilderWithUnclosedTransitionHint
    {
        private readonly string function;
        private readonly GradientDirection? direction;
        private List<GradientParameter> parameters = new List<GradientParameter>();

        internal LinearGradientBuilder(string function) 
        {
            this.function = function;
        }

        internal LinearGradientBuilder(string function, GradientDirection direction)
        {
            this.function = function;
            this.direction = direction;
        }

        private LinearGradientBuilder(string function, GradientDirection? direction, List<GradientParameter> parameters)
        {
            this.function = function;
            this.direction = direction;
            this.parameters = parameters;
        }

        public ILinearGradientBuilderWithStops WithColorStop(ColorValue color)
        {
            var newParameters = this.parameters.ToList();
            newParameters.Add(new ColorStop(color));
            return new LinearGradientBuilder(function, direction, newParameters);
        }

        public ILinearGradientBuilderWithStops WithColorStop(ColorValue color, LengthPercentageValue from)
        {
            var newParameters = this.parameters.ToList();
            newParameters.Add(new ColorStop(color, from));
            return new LinearGradientBuilder(function, direction, newParameters);
        }

        public ILinearGradientBuilderWithStops WithColorStop(ColorValue color, LengthPercentageValue from, LengthPercentageValue to)
        {
            var newParameters = this.parameters.ToList();
            newParameters.Add(new ColorStop(color, from, to));
            return new LinearGradientBuilder(function, direction, newParameters);
        }

        ILinearGradientBuilderWithStop ILinearGradientBuilderWithoutStops.WithColorStop(ColorValue color)
            => WithColorStop(color);

        public ILinearGradientBuilderWithUnclosedTransitionHint WithTransitionHint(LengthPercentageValue hint)
        {
            var newParameters = this.parameters.ToList();
            newParameters.Add(new TransitionHint(hint));
            return new LinearGradientBuilder(function, direction, newParameters);
        }

        public GradientValue Build()
        {
            var sb = new StringBuilder();
            sb.Append(function);
            sb.Append("(");
            if (direction is not null)
            {
                sb.Append(direction);
                sb.Append(",");
            }
            foreach(var colorStop in parameters)
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
