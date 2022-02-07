using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCss.Values.Color.Named
{
    public sealed class BlueColor: NamedColor
    {
        private BlueColor() : base("blue") { }

        internal static readonly BlueColor Blue = new BlueColor();
    }
}
