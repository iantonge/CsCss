namespace CsCss.Values.Numeric.Frequency
{
    public class FrequencyUnit : Unit
    {
        private FrequencyUnit(string u) : base(u)
        {
        }

        internal static readonly FrequencyUnit Hz = new FrequencyUnit("Hz");
        internal static readonly FrequencyUnit KHz = new FrequencyUnit("kHz");
    }
}
