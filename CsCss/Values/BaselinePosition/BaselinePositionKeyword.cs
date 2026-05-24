namespace CsCss.Values.BaselinePosition;

public sealed class BaselinePositionKeyword : Value
{
    private BaselinePositionKeyword(string v) : base(v) { }

    internal static readonly BaselinePositionKeyword Baseline = new("baseline");
    internal static readonly BaselinePositionKeyword FirstBaseline = new("first baseline");
    internal static readonly BaselinePositionKeyword LastBaseline = new("last baseline");
}
