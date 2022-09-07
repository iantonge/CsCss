using CsCss.Properties.AlignContent;
using Xunit;

namespace CsCss.Tests.Properties.AlignContent
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersAlignContent()
        {
            Assert.Equal("align-content", Keywords.AlignContent.ToString());
            Assert.Equal(typeof(AlignContentProperty), Keywords.AlignContent.GetType());
        }
    }
}
