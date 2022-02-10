namespace CsCss.Values
{
    public abstract class Unit
    {
        private readonly string unit;

        protected Unit(string u)
        {
            unit = u;
        }

        public override string ToString()
        {
            return unit;
        }
    }
}
