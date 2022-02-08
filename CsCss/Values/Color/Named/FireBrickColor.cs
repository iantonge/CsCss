namespace CsCss.Values.Color.Named
{
    public sealed class FireBrickColor : NamedColor
    {
        private FireBrickColor() : base("firebrick") { }

        internal static readonly FireBrickColor FireBrick = new FireBrickColor();
    }
}