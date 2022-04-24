using CsCss.Values.General;

namespace CsCss.Values.CursorStyle
{
    public sealed class CursorStyleKeyword : Value
    {
        private CursorStyleKeyword(string v) : base(v) { }

        internal static readonly CursorStyleKeyword ContextMenu = new CursorStyleKeyword("context-menu");
        internal static readonly CursorStyleKeyword Help = new CursorStyleKeyword("help");
        internal static readonly CursorStyleKeyword Pointer = new CursorStyleKeyword("pointer");
        internal static readonly CursorStyleKeyword Progress = new CursorStyleKeyword("progress");
        internal static readonly CursorStyleKeyword Wait = new CursorStyleKeyword("wait");
        internal static readonly CursorStyleKeyword Cell = new CursorStyleKeyword("cell");
        internal static readonly CursorStyleKeyword Crosshair = new CursorStyleKeyword("crosshair");
        internal static readonly CursorStyleKeyword VerticalText = new CursorStyleKeyword("vertical-text");
        internal static readonly CursorStyleKeyword Alias = new CursorStyleKeyword("alias");
        internal static readonly CursorStyleKeyword Copy = new CursorStyleKeyword("copy");
        internal static readonly CursorStyleKeyword Move = new CursorStyleKeyword("move");
        internal static readonly CursorStyleKeyword NoDrop = new CursorStyleKeyword("no-drop");
        internal static readonly CursorStyleKeyword NotAllowed = new CursorStyleKeyword("not-allowed");
        internal static readonly CursorStyleKeyword EResize = new CursorStyleKeyword("e-resize");
        internal static readonly CursorStyleKeyword NResize = new CursorStyleKeyword("n-resize");
        internal static readonly CursorStyleKeyword NEResize = new CursorStyleKeyword("ne-resize");
        internal static readonly CursorStyleKeyword NWResize = new CursorStyleKeyword("nw-resize");
        internal static readonly CursorStyleKeyword SResize = new CursorStyleKeyword("s-resize");
        internal static readonly CursorStyleKeyword SEResize = new CursorStyleKeyword("se-resize");
        internal static readonly CursorStyleKeyword SWResize = new CursorStyleKeyword("sw-resize");
        internal static readonly CursorStyleKeyword WResize = new CursorStyleKeyword("w-resize");
        internal static readonly CursorStyleKeyword EWResize = new CursorStyleKeyword("ew-resize");
        internal static readonly CursorStyleKeyword NSResize = new CursorStyleKeyword("ns-resize");
        internal static readonly CursorStyleKeyword NESWResize = new CursorStyleKeyword("nesw-resize");
        internal static readonly CursorStyleKeyword NWSEResize = new CursorStyleKeyword("nwse-resize");
        internal static readonly CursorStyleKeyword ColResize = new CursorStyleKeyword("col-resize");
        internal static readonly CursorStyleKeyword RowResize = new CursorStyleKeyword("row-resize");
        internal static readonly CursorStyleKeyword AllScroll = new CursorStyleKeyword("all-scroll");
        internal static readonly CursorStyleKeyword ZoomIn = new CursorStyleKeyword("zoom-in");
        internal static readonly CursorStyleKeyword ZoomOut = new CursorStyleKeyword("zoom-out");
        internal static readonly CursorStyleKeyword Grab = new CursorStyleKeyword("grab");
        internal static readonly CursorStyleKeyword Grabbing = new CursorStyleKeyword("grabbing");

        public static implicit operator CursorStyleKeyword(AutoKeyword value)
        {
            return new CursorStyleKeyword(value.ToString());
        }

        public static implicit operator CursorStyleKeyword(NoneKeyword value)
        {
            return new CursorStyleKeyword(value.ToString());
        }

        public static implicit operator CursorStyleKeyword(DefaultKeyword value)
        {
            return new CursorStyleKeyword(value.ToString());
        }

        public static implicit operator CursorStyleKeyword(TextKeyword value)
        {
            return new CursorStyleKeyword(value.ToString());
        }
    }
}
