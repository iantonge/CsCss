namespace CsCss.Values.Color.Named
{
    public sealed class BlueColor : NamedColor
    {
        private BlueColor() : base("blue") { }

        internal static readonly BlueColor Blue = new BlueColor();
    }
}