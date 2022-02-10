namespace CsCss.Values.Time
{
    public class TimeUnit : Unit
    {
        private TimeUnit(string u) : base(u)
        {
        }

        internal static readonly TimeUnit S = new TimeUnit("s");
        internal static readonly TimeUnit Ms = new TimeUnit("ms");
    }
}
