using CsCss.Values.General;
using Xunit;

namespace CsCss.Tests.Values.General
{
    public class NoneKeywordTests
    {
        [Fact]
        public void RendersNoneKeyword()
        {
            Assert.Equal("none", Statics.None.ToString());
            Assert.Equal(typeof(NoneKeyword), Statics.None.GetType());
        }
    }
}
