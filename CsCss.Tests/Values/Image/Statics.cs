using CsCss.Values.Image;
using Xunit;

namespace CsCss.Tests.Values.Image
{
    public class StaticsTests
    {
        [Fact]
        public void CanRenderImageSet()
        {
            var result = Statics.ImageSet("image1", (Statics.Url("path/to/image.jpg"), 10.Dpi()));
            Assert.Equal("image-set('image1',url('path/to/image.jpg') 10dpi)", result.ToString());
            Assert.Equal(typeof(ImageSetValue), result.GetType());
        }
    }
}
