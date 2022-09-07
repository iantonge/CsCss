using CsCss.Properties.AlignItems;
using Xunit;

namespace CsCss.Tests.Properties.AlignItems
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersAlignContent()
        {
            Assert.Equal("align-items", Keywords.AlignItems.ToString());
            Assert.Equal(typeof(AlignItemsProperty), Keywords.AlignItems.GetType());
        }
    }
}
