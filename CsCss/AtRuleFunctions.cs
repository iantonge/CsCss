using CsCss.AtRules.Media;
using CsCss.AtRules.Supports;

namespace CsCss;

public static partial class AtRuleFunctions
{
    public static MediaRuleScope Media(MediaQuery query) => new(query);

    public static SupportsRuleScope Supports(Declarations declarations) => new(SupportsCondition.Declaration(declarations));

    public static SupportsRuleScope And(this SupportsRuleScope scope, SupportsRuleScope grouped) => new(scope.Condition & grouped.Condition.Group());

    public static SupportsRuleScope Or(this SupportsRuleScope scope, SupportsRuleScope grouped) => new(scope.Condition | grouped.Condition.Group());
}
