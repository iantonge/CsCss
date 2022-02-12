namespace CsCss.Values.Gradient
{
    internal abstract class ColorStopItem
    {
        private readonly string value;

        protected ColorStopItem(string v)
        {
            value = v;
        }

        public override string ToString()
        {
            return value;
        }
    }
}
