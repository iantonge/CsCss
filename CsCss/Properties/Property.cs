namespace CsCss.Properties
{
    public abstract class Property
    {
        private readonly string name;

        protected Property(string v)
        {
            name = v;
        }
        public override string ToString() => name;
    }
}
