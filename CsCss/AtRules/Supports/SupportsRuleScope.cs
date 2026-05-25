namespace CsCss.AtRules.Supports;

public sealed class SupportsRuleScope
{
    internal SupportsRuleScope(SupportsCondition condition) => Condition = condition;

    internal SupportsCondition Condition { get; }

    public SupportsRuleScope And(Declarations declarations) => new(Condition & SupportsCondition.Declaration(declarations));

    public SupportsRuleScope Or(Declarations declarations) => new(Condition | SupportsCondition.Declaration(declarations));

    public SupportsRuleScope Not() => new(!Condition);

    public override string ToString() => Condition.ToString();
}
