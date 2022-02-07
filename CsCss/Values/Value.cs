namespace CsCss.Values
{
    public abstract class Value
    {
        private readonly string value;

        protected Value(string v)
        {
            value = v;
        }

        public override string ToString()
        {
            return value;
        }
    }
}
