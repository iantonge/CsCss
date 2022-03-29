using CsCss.Values.General;

namespace CsCss.Values.Line
{
    public sealed class LineStyleValue: Value
    {
        private LineStyleValue(string v) : base(v) { }

        internal static readonly LineStyleValue Hidden = new LineStyleValue("hidden");
        internal static readonly LineStyleValue Dotted = new LineStyleValue("dotted");
        internal static readonly LineStyleValue Dashed = new LineStyleValue("dashed");
        internal static readonly LineStyleValue Solid = new LineStyleValue("solid");
        internal static readonly LineStyleValue Double = new LineStyleValue("double");
        internal static readonly LineStyleValue Groove = new LineStyleValue("groove");
        internal static readonly LineStyleValue Ridge = new LineStyleValue("ridge");
        internal static readonly LineStyleValue Inset = new LineStyleValue("inset");
        internal static readonly LineStyleValue Outset = new LineStyleValue("outset");

        public static implicit operator LineStyleValue(NoneKeyword value)
        {
            return new LineStyleValue(value.ToString());
        }
    }
}
