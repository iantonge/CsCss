namespace CsCss.Values.Numeric.Angle
{
    public class AngleUnit : Unit
    {
        private AngleUnit(string u) : base(u)
        {
        }

        internal static readonly AngleUnit Deg = new AngleUnit("deg");
        internal static readonly AngleUnit Rad = new AngleUnit("rad");
        internal static readonly AngleUnit Grad = new AngleUnit("grad");
        internal static readonly AngleUnit Turn = new AngleUnit("turn");
    }
}
