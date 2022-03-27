using CsCss.Properties.BackgroundRepeat;

namespace CsCss
{
    public sealed partial class Declarations
    {
        public BackgroundRepeatValue this[BackgroundRepeatProperty property]
        {
            set => declarations.Add((property, value));
        }
    }
}
