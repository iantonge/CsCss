using CsCss.Values.Image;
using System.Text;

namespace CsCss
{
    public static partial class Statics
    {
        public static ImageValue ImageSet(params ImageSetOption[] imageOptions)
        {
            var sb = new StringBuilder();
            sb.Append("image-set(");
            var enumerator = imageOptions.GetEnumerator();
            enumerator.MoveNext();
            sb.Append(enumerator.Current);
            while (enumerator.MoveNext())
            {
                sb.Append("," + enumerator.Current);
            }
            sb.Append(")");
            return new ImageValue(sb.ToString());
        }
    }
}
