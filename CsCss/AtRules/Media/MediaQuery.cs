namespace CsCss.AtRules.Media;

public sealed class MediaQuery
{
    private readonly string query;

    internal MediaQuery(string query) => this.query = query;

    public static MediaQuery operator !(MediaQuery query) => new($"not {query}");

    public static MediaQuery operator &(MediaQuery left, MediaQuery right) => new($"{left} and {right}");

    public static MediaQuery operator |(MediaQuery left, MediaQuery right) => new($"{left}, {right}");

    public override string ToString() => query;
}
