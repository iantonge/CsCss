namespace CsCss.Values.Gradient.Conic
{
    internal abstract class AngularColorStopItem
    {
        private readonly string value;

        protected AngularColorStopItem(string v)
        {
            value = v;
        }

        public override string ToString()
        {
            return value;
        }
    }
}
