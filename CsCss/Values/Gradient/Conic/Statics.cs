﻿using CsCss.Values.Gradient.Conic;

namespace CsCss
{
    public static partial class Statics
    {
        public static IConicGradientBuilder BuildConicGradient()
        {
            return new ConicGradientBuilder("conic-gradient");
        }

        public static IConicGradientBuilder BuildRepeatingConicGradient()
        {
            return new ConicGradientBuilder("repeating-conic-gradient");
        }
    }
}
