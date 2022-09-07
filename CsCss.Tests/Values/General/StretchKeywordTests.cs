using CsCss.Values.General;
using Xunit;

namespace CsCss.Tests.Values.General
{
    public class StretchKeywordTests
    {
        [Fact]
        public void RendersTextKeyword()
        {
            Assert.Equal("stretch", Stretch.ToString());
            Assert.Equal(typeof(StretchKeyword), Stretch.GetType());
        }
    }
}
