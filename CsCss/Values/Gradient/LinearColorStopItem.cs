namespace CsCss.Values.Gradient
{
    internal abstract class LinearColorStopItem
    {
        private readonly string value;

        protected LinearColorStopItem(string v)
        {
            value = v;
        }

        public override string ToString()
        {
            return value;
        }
    }
}
