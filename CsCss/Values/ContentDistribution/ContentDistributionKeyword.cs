namespace CsCss.Values.ContentDistribution
{
    public sealed class ContentDistributionKeyword : Value
    {
        private ContentDistributionKeyword(string v) : base(v) { }

        internal static readonly ContentDistributionKeyword SpaceBetween = new ContentDistributionKeyword("space-between");
        internal static readonly ContentDistributionKeyword SpaceAround = new ContentDistributionKeyword("space-around");
        internal static readonly ContentDistributionKeyword SpaceEvenly = new ContentDistributionKeyword("space-evenly");
    }
}
