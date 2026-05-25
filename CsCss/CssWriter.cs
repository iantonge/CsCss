namespace CsCss;

public sealed class CssWriter
{
    private readonly TextWriter writer;

    public CssWriter(TextWriter writer, CssFormatting formatting = CssFormatting.Indented)
    {
        this.writer = writer ?? throw new ArgumentNullException(nameof(writer));
        Formatting = formatting;
    }

    public CssFormatting Formatting { get; }

    internal bool IsMinified => Formatting == CssFormatting.Minified;

    internal void Write(char value) => writer.Write(value);

    internal void Write(string? value) => writer.Write(value);

    internal void WriteIndent(int indentLevel)
    {
        if (IsMinified)
        {
            return;
        }

        writer.Write(new string(' ', indentLevel * 4));
    }

    internal void WriteLine()
    {
        if (!IsMinified)
        {
            writer.WriteLine();
        }
    }

    internal void WriteSpace()
    {
        if (!IsMinified)
        {
            writer.Write(' ');
        }
    }
}
