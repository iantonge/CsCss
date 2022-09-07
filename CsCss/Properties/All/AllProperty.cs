namespace CsCss.Properties.All
{
    public sealed class AllProperty : Property
    {
        private AllProperty() : base("all") { }

        internal static readonly AllProperty All = new AllProperty();
    }
}
