namespace CsCss.AtRules.Media;

public sealed class MediaRuleScope
{
    internal MediaRuleScope(MediaQuery query) => Query = query;

    internal MediaQuery Query { get; }
}
