namespace CsCss.Values.Sizing
{
    public sealed class ContainKeyword : Value
    {
        private ContainKeyword() : base("contain") { }

        internal static readonly ContainKeyword Contain = new ContainKeyword();
    }
}
