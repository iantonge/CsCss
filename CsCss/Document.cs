using System.Text;

namespace CsCss
{
    public sealed class Document
    {
        internal readonly List<(Selector selector, Declarations declarations)> StyleRules;

        public Document()
        {
            StyleRules = new List<(Selector, Declarations)>();
        }

        public Document(Document original)
        {
            StyleRules = original.StyleRules.ToList();
        }

        public Declarations this[Selector ruleSelector]
        {
            init
            {
                StyleRules.Add((ruleSelector, value));
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var style in StyleRules)
            {
                sb.Append(style.selector);
                sb.Append(": {");
                foreach (var declaration in style.declarations.ToStrings())
                {
                    sb.Append("\n    ");
                    sb.Append(declaration);
                    sb.Append(";");
                }
                sb.Append("\n}\n");
            }
            return sb.ToString();
        }
    }
}