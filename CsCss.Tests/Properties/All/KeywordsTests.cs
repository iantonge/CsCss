using CsCss.Properties.All;
using Xunit;

namespace CsCss.Tests.Properties.All
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersAlignContent()
        {
            Assert.Equal("all", Keywords.All.ToString());
            Assert.Equal(typeof(AllProperty), Keywords.All.GetType());
        }
    }
}
