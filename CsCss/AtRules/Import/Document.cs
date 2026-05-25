using CsCss.AtRules.Import;

namespace CsCss;

public sealed partial class Document
{
    public ImportValue this[ImportAtRule atRule]
    {
        init
        {
            if (Rules.Any(rule => !rule.IsImportRule))
            {
                throw new InvalidOperationException("@import rules must precede all non-import rules.");
            }

            Rules.Add(new ImportRule(value));
        }
    }
}
