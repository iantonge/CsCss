namespace CsCss.Properties.BackgroundRepeat
{
    public sealed class BackgroundRepeatProperty : Property
    {
        private BackgroundRepeatProperty() : base("background-repeat") { }

        internal static readonly BackgroundRepeatProperty BackgroundRepeat = new BackgroundRepeatProperty();
    }
}
