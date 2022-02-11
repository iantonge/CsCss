using CsCss.Values.Resolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsCss.Values.Image
{
    public sealed class ImageSetOption
    {
        private readonly string value;

        private ImageSetOption(string v)
        {
            value = v;
        }

        public override string ToString()
        {
            return value;
        }

        public static implicit operator ImageSetOption((ImageValue image, ResolutionValue resolution) value)
        {
            return new ImageSetOption(value.image + " " + value.resolution);
        }

        public static implicit operator ImageSetOption((string image, ResolutionValue resolution) value)
        {
            return new ImageSetOption("'" + value.image + "' " + value.resolution);
        }

        public static implicit operator ImageSetOption(ImageValue image)
        {
            return new ImageSetOption(image.ToString());
        }

        public static implicit operator ImageSetOption(string image)
        {
            return new ImageSetOption("'" + image + "'");
        }
    }
}
