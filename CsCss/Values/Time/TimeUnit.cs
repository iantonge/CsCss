namespace CsCss.Values.Time;

public class TimeUnit : Unit
{
    private TimeUnit(string u) : base(u)
    {
    }

    internal static readonly TimeUnit S = new("s");
    internal static readonly TimeUnit Ms = new("ms");
}
