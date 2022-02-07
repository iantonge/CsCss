namespace CsCss.Values.Numeric.LengthPercentage.Percentage
{
    public class PercentageUnit : Unit
    {
        private PercentageUnit(string u) : base(u)
        {
        }

        internal static readonly PercentageUnit Percent = new PercentageUnit("%");
    }
}
