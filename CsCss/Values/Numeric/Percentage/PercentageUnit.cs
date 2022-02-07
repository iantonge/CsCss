namespace CsCss.Values.Numeric.Percentage
{
    public class PercentageUnit : Unit
    {
        private PercentageUnit(string u) : base(u)
        {
        }

        internal static readonly PercentageUnit Percent = new PercentageUnit("%");
    }
}
