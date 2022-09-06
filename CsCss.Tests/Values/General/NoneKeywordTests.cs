using CsCss.Values.General;
using Xunit;

namespace CsCss.Tests.Values.General
{
    public class NoneKeywordTests
    {
        [Fact]
        public void RendersNoneKeyword()
        {
            Assert.Equal("none", None.ToString());
            Assert.Equal(typeof(NoneKeyword), None.GetType());
        }
    }
}
