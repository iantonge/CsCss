﻿using CsCss.Values.Color.Named;
using Xunit;

namespace CsCss.Tests.Values.Color.Named
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersNamedColors()
        {
            Assert.Equal("aliceblue", Keywords.AliceBlue.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.AliceBlue.GetType());
            Assert.Equal("antiquewhite", Keywords.AntiqueWhite.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.AntiqueWhite.GetType());
            Assert.Equal("aqua", Keywords.Aqua.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Aqua.GetType());
            Assert.Equal("aquamarine", Keywords.Aquamarine.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Aquamarine.GetType());
            Assert.Equal("azure", Keywords.Azure.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Azure.GetType());
            Assert.Equal("beige", Keywords.Beige.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Beige.GetType());
            Assert.Equal("bisque", Keywords.Bisque.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Bisque.GetType());
            Assert.Equal("black", Keywords.Black.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Black.GetType());
            Assert.Equal("blanchedalmond", Keywords.BlanchedAlmond.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.BlanchedAlmond.GetType());
            Assert.Equal("blue", Keywords.Blue.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Blue.GetType());
            Assert.Equal("blueviolet", Keywords.BlueViolet.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.BlueViolet.GetType());
            Assert.Equal("brown", Keywords.Brown.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Brown.GetType());
            Assert.Equal("burlywood", Keywords.Burlywood.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Burlywood.GetType());
            Assert.Equal("cadetblue", Keywords.CadetBlue.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.CadetBlue.GetType());
            Assert.Equal("chartreuse", Keywords.Chartreuse.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Chartreuse.GetType());
            Assert.Equal("chocolate", Keywords.Chocolate.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Chocolate.GetType());
            Assert.Equal("coral", Keywords.Coral.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Coral.GetType());
            Assert.Equal("cornflowerblue", Keywords.CornflowerBlue.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.CornflowerBlue.GetType());
            Assert.Equal("cornsilk", Keywords.Cornsilk.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Cornsilk.GetType());
            Assert.Equal("crimson", Keywords.Crimson.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Crimson.GetType());
            Assert.Equal("cyan", Keywords.Cyan.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Cyan.GetType());
            Assert.Equal("darkblue", Keywords.DarkBlue.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.DarkBlue.GetType());
            Assert.Equal("darkcyan", Keywords.DarkCyan.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.DarkCyan.GetType());
            Assert.Equal("darkgoldenrod", Keywords.DarkGoldenrod.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.DarkGoldenrod.GetType());
            Assert.Equal("darkgray", Keywords.DarkGray.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.DarkGray.GetType());
            Assert.Equal("darkgreen", Keywords.DarkGreen.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.DarkGreen.GetType());
            Assert.Equal("darkkhaki", Keywords.DarkKhaki.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.DarkKhaki.GetType());
            Assert.Equal("darkmagenta", Keywords.DarkMagenta.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.DarkMagenta.GetType());
            Assert.Equal("darkolivegreen", Keywords.DarkOliveGreen.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.DarkOliveGreen.GetType());
            Assert.Equal("darkorange", Keywords.DarkOrange.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.DarkOrange.GetType());
            Assert.Equal("darkorchid", Keywords.DarkOrchid.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.DarkOrchid.GetType());
            Assert.Equal("darkred", Keywords.DarkRed.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.DarkRed.GetType());
            Assert.Equal("darksalmon", Keywords.DarkSalmon.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.DarkSalmon.GetType());
            Assert.Equal("darkseagreen", Keywords.DarkSeaGreen.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.DarkSeaGreen.GetType());
            Assert.Equal("darkslateblue", Keywords.DarkSlateBlue.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.DarkSlateBlue.GetType());
            Assert.Equal("darkslategray", Keywords.DarkSlateGray.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.DarkSlateGray.GetType());
            Assert.Equal("darkturquoise", Keywords.DarkTurquoise.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.DarkTurquoise.GetType());
            Assert.Equal("darkviolet", Keywords.DarkViolet.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.DarkViolet.GetType());
            Assert.Equal("deeppink", Keywords.DeepPink.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.DeepPink.GetType());
            Assert.Equal("deepskyblue", Keywords.DeepSkyBlue.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.DeepSkyBlue.GetType());
            Assert.Equal("dimgray", Keywords.DimGray.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.DimGray.GetType());
            Assert.Equal("dodgerblue", Keywords.DodgerBlue.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.DodgerBlue.GetType());
            Assert.Equal("firebrick", Keywords.Firebrick.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Firebrick.GetType());
            Assert.Equal("floralwhite", Keywords.FloralWhite.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.FloralWhite.GetType());
            Assert.Equal("forestgreen", Keywords.ForestGreen.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.ForestGreen.GetType());
            Assert.Equal("fuchsia", Keywords.Fuchsia.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Fuchsia.GetType());
            Assert.Equal("gainsboro", Keywords.Gainsboro.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Gainsboro.GetType());
            Assert.Equal("ghostwhite", Keywords.GhostWhite.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.GhostWhite.GetType());
            Assert.Equal("gold", Keywords.Gold.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Gold.GetType());
            Assert.Equal("goldenrod", Keywords.Goldenrod.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Goldenrod.GetType());
            Assert.Equal("gray", Keywords.Gray.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Gray.GetType());
            Assert.Equal("green", Keywords.Green.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Green.GetType());
            Assert.Equal("greenyellow", Keywords.GreenYellow.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.GreenYellow.GetType());
            Assert.Equal("honeydew", Keywords.Honeydew.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Honeydew.GetType());
            Assert.Equal("hotpink", Keywords.HotPink.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.HotPink.GetType());
            Assert.Equal("indianred", Keywords.IndianRed.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.IndianRed.GetType());
            Assert.Equal("indigo", Keywords.Indigo.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Indigo.GetType());
            Assert.Equal("ivory", Keywords.Ivory.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Ivory.GetType());
            Assert.Equal("khaki", Keywords.Khaki.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Khaki.GetType());
            Assert.Equal("lavender", Keywords.Lavender.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Lavender.GetType());
            Assert.Equal("lavenderblush", Keywords.LavenderBlush.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.LavenderBlush.GetType());
            Assert.Equal("lawngreen", Keywords.LawnGreen.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.LawnGreen.GetType());
            Assert.Equal("lemonchiffon", Keywords.LemonChiffon.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.LemonChiffon.GetType());
            Assert.Equal("lightblue", Keywords.LightBlue.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.LightBlue.GetType());
            Assert.Equal("lightcoral", Keywords.LightCoral.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.LightCoral.GetType());
            Assert.Equal("lightcyan", Keywords.LightCyan.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.LightCyan.GetType());
            Assert.Equal("lightgoldenrodyellow", Keywords.LightGoldenrodYellow.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.LightGoldenrodYellow.GetType());
            Assert.Equal("lightgray", Keywords.LightGray.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.LightGray.GetType());
            Assert.Equal("lightgreen", Keywords.LightGreen.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.LightGreen.GetType());
            Assert.Equal("lightpink", Keywords.LightPink.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.LightPink.GetType());
            Assert.Equal("lightsalmon", Keywords.LightSalmon.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.LightSalmon.GetType());
            Assert.Equal("lightseagreen", Keywords.LightSeaGreen.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.LightSeaGreen.GetType());
            Assert.Equal("lightskyblue", Keywords.LightSkyBlue.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.LightSkyBlue.GetType());
            Assert.Equal("lightslategray", Keywords.LightSlateGray.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.LightSlateGray.GetType());
            Assert.Equal("lightsteelblue", Keywords.LightSteelBlue.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.LightSteelBlue.GetType());
            Assert.Equal("lightyellow", Keywords.LightYellow.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.LightYellow.GetType());
            Assert.Equal("lime", Keywords.Lime.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Lime.GetType());
            Assert.Equal("limegreen", Keywords.LimeGreen.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.LimeGreen.GetType());
            Assert.Equal("linen", Keywords.Linen.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Linen.GetType());
            Assert.Equal("magenta", Keywords.Magenta.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Magenta.GetType());
            Assert.Equal("maroon", Keywords.Maroon.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Maroon.GetType());
            Assert.Equal("mediumaquamarine", Keywords.MediumAquamarine.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.MediumAquamarine.GetType());
            Assert.Equal("mediumblue", Keywords.MediumBlue.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.MediumBlue.GetType());
            Assert.Equal("mediumorchid", Keywords.MediumOrchid.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.MediumOrchid.GetType());
            Assert.Equal("mediumpurple", Keywords.MediumPurple.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.MediumPurple.GetType());
            Assert.Equal("mediumseagreen", Keywords.MediumSeaGreen.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.MediumSeaGreen.GetType());
            Assert.Equal("mediumslateblue", Keywords.MediumSlateBlue.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.MediumSlateBlue.GetType());
            Assert.Equal("mediumspringgreen", Keywords.MediumSpringGreen.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.MediumSpringGreen.GetType());
            Assert.Equal("mediumturquoise", Keywords.MediumTurquoise.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.MediumTurquoise.GetType());
            Assert.Equal("mediumvioletred", Keywords.MediumVioletRed.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.MediumVioletRed.GetType());
            Assert.Equal("midnightblue", Keywords.MidnightBlue.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.MidnightBlue.GetType());
            Assert.Equal("mintcream", Keywords.MintCream.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.MintCream.GetType());
            Assert.Equal("mistyrose", Keywords.MistyRose.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.MistyRose.GetType());
            Assert.Equal("moccasin", Keywords.Moccasin.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Moccasin.GetType());
            Assert.Equal("navajowhite", Keywords.NavajoWhite.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.NavajoWhite.GetType());
            Assert.Equal("navy", Keywords.Navy.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Navy.GetType());
            Assert.Equal("oldlace", Keywords.OldLace.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.OldLace.GetType());
            Assert.Equal("olive", Keywords.Olive.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Olive.GetType());
            Assert.Equal("olivedrab", Keywords.OliveDrab.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.OliveDrab.GetType());
            Assert.Equal("orange", Keywords.Orange.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Orange.GetType());
            Assert.Equal("orangered", Keywords.OrangeRed.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.OrangeRed.GetType());
            Assert.Equal("orchid", Keywords.Orchid.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Orchid.GetType());
            Assert.Equal("palegoldenrod", Keywords.PaleGoldenrod.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.PaleGoldenrod.GetType());
            Assert.Equal("palegreen", Keywords.PaleGreen.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.PaleGreen.GetType());
            Assert.Equal("paleturquoise", Keywords.PaleTurquoise.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.PaleTurquoise.GetType());
            Assert.Equal("palevioletred", Keywords.PaleVioletRed.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.PaleVioletRed.GetType());
            Assert.Equal("papayawhip", Keywords.PapayaWhip.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.PapayaWhip.GetType());
            Assert.Equal("peachpuff", Keywords.PeachPuff.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.PeachPuff.GetType());
            Assert.Equal("peru", Keywords.Peru.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Peru.GetType());
            Assert.Equal("pink", Keywords.Pink.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Pink.GetType());
            Assert.Equal("plum", Keywords.Plum.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Plum.GetType());
            Assert.Equal("powderblue", Keywords.PowderBlue.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.PowderBlue.GetType());
            Assert.Equal("purple", Keywords.Purple.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Purple.GetType());
            Assert.Equal("red", Keywords.Red.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Red.GetType());
            Assert.Equal("rosybrown", Keywords.RosyBrown.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.RosyBrown.GetType());
            Assert.Equal("royalblue", Keywords.RoyalBlue.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.RoyalBlue.GetType());
            Assert.Equal("saddlebrown", Keywords.SaddleBrown.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.SaddleBrown.GetType());
            Assert.Equal("salmon", Keywords.Salmon.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Salmon.GetType());
            Assert.Equal("sandybrown", Keywords.SandyBrown.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.SandyBrown.GetType());
            Assert.Equal("seagreen", Keywords.SeaGreen.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.SeaGreen.GetType());
            Assert.Equal("seashell", Keywords.Seashell.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Seashell.GetType());
            Assert.Equal("sienna", Keywords.Sienna.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Sienna.GetType());
            Assert.Equal("silver", Keywords.Silver.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Silver.GetType());
            Assert.Equal("skyblue", Keywords.SkyBlue.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.SkyBlue.GetType());
            Assert.Equal("slateblue", Keywords.SlateBlue.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.SlateBlue.GetType());
            Assert.Equal("slategray", Keywords.SlateGray.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.SlateGray.GetType());
            Assert.Equal("snow", Keywords.Snow.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Snow.GetType());
            Assert.Equal("springgreen", Keywords.SpringGreen.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.SpringGreen.GetType());
            Assert.Equal("steelblue", Keywords.SteelBlue.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.SteelBlue.GetType());
            Assert.Equal("tan", Keywords.Tan.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Tan.GetType());
            Assert.Equal("teal", Keywords.Teal.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Teal.GetType());
            Assert.Equal("thistle", Keywords.Thistle.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Thistle.GetType());
            Assert.Equal("tomato", Keywords.Tomato.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Tomato.GetType());
            Assert.Equal("turquoise", Keywords.Turquoise.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Turquoise.GetType());
            Assert.Equal("violet", Keywords.Violet.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Violet.GetType());
            Assert.Equal("wheat", Keywords.Wheat.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Wheat.GetType());
            Assert.Equal("white", Keywords.White.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.White.GetType());
            Assert.Equal("whitesmoke", Keywords.WhiteSmoke.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.WhiteSmoke.GetType());
            Assert.Equal("yellow", Keywords.Yellow.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.Yellow.GetType());
            Assert.Equal("yellowgreen", Keywords.YellowGreen.ToString());
            Assert.Equal(typeof(NamedColor), Keywords.YellowGreen.GetType());

        }
    }
}
