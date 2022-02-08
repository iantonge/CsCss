namespace CsCss.Values.Color.Named
{
    public sealed class FirebrickColor : NamedColor
    {
        private FirebrickColor() : base("firebrick") { }

        internal static readonly FirebrickColor Firebrick = new FirebrickColor();
    }
}