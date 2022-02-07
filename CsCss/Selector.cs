namespace CsCss
{
    public sealed class Selector
    {
        private readonly string selector;
        private Selector(string s)
        {
            selector = s;
        }

        public override string ToString() => selector;

        public static implicit operator Selector(string s) => new Selector(s);
    }
}
