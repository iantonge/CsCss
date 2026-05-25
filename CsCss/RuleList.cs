using System.Globalization;

namespace CsCss;

public partial class RuleList
{
    internal readonly List<CssRule> Rules;

    public RuleList() => Rules = new();

    public RuleList(RuleList original) => Rules = original.Rules.ToList();

    public Declarations this[Selector ruleSelector]
    {
        init
        {
            Rules.Add(new StyleRule(ruleSelector, value));
        }
    }

    public void WriteTo(CssWriter writer)
    {
        ArgumentNullException.ThrowIfNull(writer);

        WriteTo(writer, 0);
    }

    public string ToCssString(CssFormatting formatting = CssFormatting.Indented)
    {
        using StringWriter stringWriter = new(CultureInfo.InvariantCulture);
        WriteTo(new CssWriter(stringWriter, formatting));
        return stringWriter.ToString();
    }

#pragma warning disable CS0809
    [Obsolete("Use ToCssString(...) or WriteTo(...).", true)]
    public override string ToString() => throw new NotSupportedException("Use ToCssString(...) or WriteTo(...).");
#pragma warning restore CS0809

    internal void WriteTo(CssWriter writer, int indentLevel)
    {
        for (var i = 0; i < Rules.Count; i++)
        {
            if (i > 0)
            {
                writer.WriteLine();
            }

            Rules[i].WriteTo(writer, indentLevel);
        }
    }
}
