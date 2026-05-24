using CsCss.Values.General;

namespace CsCss.Values.CursorStyle;

public sealed class CursorStyleKeyword : Value
{
    private CursorStyleKeyword(string v) : base(v) { }

    internal static readonly CursorStyleKeyword ContextMenu = new("context-menu");
    internal static readonly CursorStyleKeyword Help = new("help");
    internal static readonly CursorStyleKeyword Pointer = new("pointer");
    internal static readonly CursorStyleKeyword Progress = new("progress");
    internal static readonly CursorStyleKeyword Wait = new("wait");
    internal static readonly CursorStyleKeyword Cell = new("cell");
    internal static readonly CursorStyleKeyword Crosshair = new("crosshair");
    internal static readonly CursorStyleKeyword VerticalText = new("vertical-text");
    internal static readonly CursorStyleKeyword Alias = new("alias");
    internal static readonly CursorStyleKeyword Copy = new("copy");
    internal static readonly CursorStyleKeyword Move = new("move");
    internal static readonly CursorStyleKeyword NoDrop = new("no-drop");
    internal static readonly CursorStyleKeyword NotAllowed = new("not-allowed");
    internal static readonly CursorStyleKeyword EResize = new("e-resize");
    internal static readonly CursorStyleKeyword NResize = new("n-resize");
    internal static readonly CursorStyleKeyword NEResize = new("ne-resize");
    internal static readonly CursorStyleKeyword NWResize = new("nw-resize");
    internal static readonly CursorStyleKeyword SResize = new("s-resize");
    internal static readonly CursorStyleKeyword SEResize = new("se-resize");
    internal static readonly CursorStyleKeyword SWResize = new("sw-resize");
    internal static readonly CursorStyleKeyword WResize = new("w-resize");
    internal static readonly CursorStyleKeyword EWResize = new("ew-resize");
    internal static readonly CursorStyleKeyword NSResize = new("ns-resize");
    internal static readonly CursorStyleKeyword NESWResize = new("nesw-resize");
    internal static readonly CursorStyleKeyword NWSEResize = new("nwse-resize");
    internal static readonly CursorStyleKeyword ColResize = new("col-resize");
    internal static readonly CursorStyleKeyword RowResize = new("row-resize");
    internal static readonly CursorStyleKeyword AllScroll = new("all-scroll");
    internal static readonly CursorStyleKeyword ZoomIn = new("zoom-in");
    internal static readonly CursorStyleKeyword ZoomOut = new("zoom-out");
    internal static readonly CursorStyleKeyword Grab = new("grab");
    internal static readonly CursorStyleKeyword Grabbing = new("grabbing");

    public static implicit operator CursorStyleKeyword(AutoKeyword value)
    {
        return new(value.ToString());
    }

    public static implicit operator CursorStyleKeyword(NoneKeyword value)
    {
        return new(value.ToString());
    }

    public static implicit operator CursorStyleKeyword(DefaultKeyword value)
    {
        return new(value.ToString());
    }

    public static implicit operator CursorStyleKeyword(TextKeyword value)
    {
        return new(value.ToString());
    }
}
