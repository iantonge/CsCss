namespace CsCss.Values.Gradient
{
    internal abstract class GradientParameter
    {
        private readonly string value;

        protected GradientParameter(string v)
        {
            value = v;
        }

        public override string ToString()
        {
            return value;
        }
    }
}
