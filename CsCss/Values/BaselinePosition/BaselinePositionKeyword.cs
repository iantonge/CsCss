namespace CsCss.Values.BaselinePosition
{
    public sealed class BaselinePositionKeyword : Value
    {
        private BaselinePositionKeyword(string v) : base(v) { }

        internal static readonly BaselinePositionKeyword Baseline = new BaselinePositionKeyword("baseline");
        internal static readonly BaselinePositionKeyword FirstBaseline = new BaselinePositionKeyword("first baseline");
        internal static readonly BaselinePositionKeyword LastBaseline = new BaselinePositionKeyword("last baseline");
    }
}
