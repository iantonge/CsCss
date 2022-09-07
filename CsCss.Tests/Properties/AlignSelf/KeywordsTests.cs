using CsCss.Properties.AlignSelf;
using Xunit;

namespace CsCss.Tests.Properties.AlignSelf
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersAlignContent()
        {
            Assert.Equal("align-self", Keywords.AlignSelf.ToString());
            Assert.Equal(typeof(AlignSelfProperty), Keywords.AlignSelf.GetType());
        }
    }
}
