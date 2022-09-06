using CsCss.Values.General;
using Xunit;

namespace CsCss.Tests.Values.General
{
    public class NormalKeywordTests
    {
        [Fact]
        public void RendersNormalKeyword()
        {
            Assert.Equal("normal", Normal.ToString());
            Assert.Equal(typeof(NormalKeyword), Normal.GetType());
        }
    }
}
