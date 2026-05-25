namespace CsCss.AtRules.Media;

public sealed class MediaQuery
{
    private readonly string query;

    internal MediaQuery(string query) => this.query = query;

    public override string ToString() => query;
}
