using CsCss.Values;
using CsCss.Values.CursorStyle;
using CsCss.Values.General;
using CsCss.Values.Global;
using CsCss.Values.Position;
using CsCss.Values.Url;

namespace CsCss.Properties.Cursor;

public class CursorValue : Value
{
    public CursorValue(string v) : base(v) { }

    public static implicit operator CursorValue(GlobalKeyword value)
    {
        return new(value.ToString());
    }

    public static implicit operator CursorValue(AutoKeyword value)
    {
        return new(value.ToString());
    }

    public static implicit operator CursorValue(NoneKeyword value)
    {
        return new(value.ToString());
    }

    public static implicit operator CursorValue(DefaultKeyword value)
    {
        return new(value.ToString());
    }

    public static implicit operator CursorValue(TextKeyword value)
    {
        return new(value.ToString());
    }

    public static implicit operator CursorValue(CursorStyleKeyword value)
    {
        return new(value.ToString());
    }

    public static implicit operator CursorValue((UrlValue url, CursorStyleKeyword keyword) value)
    {
        return new($"{value.url} {value.keyword}");
    }

    public static implicit operator CursorValue((UrlValue url, int x, int y, CursorStyleKeyword keyword) value)
    {
        return new($"{value.url} {value.x} {value.y} {value.keyword}");
    }
}
