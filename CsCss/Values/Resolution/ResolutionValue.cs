namespace CsCss.Values.Resolution
{
    public sealed class ResolutionValue : Value
    {
        internal ResolutionValue(string v) : base(v) { }
        internal ResolutionValue(int number, ResolutionUnit unit) : base(number.ToString() + unit.ToString()) { }
        internal ResolutionValue(double number, ResolutionUnit unit) : base(number.ToString() + unit.ToString()) { }
    }
}
