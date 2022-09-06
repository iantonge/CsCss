using CsCss.Values.General;
using Xunit;

namespace CsCss.Tests.Values.General
{
    public class LocalKeywordTests
    {
        [Fact]
        public void RendersLocalKeyword()
        {
            Assert.Equal("local", Local.ToString());
            Assert.Equal(typeof(LocalKeyword), Local.GetType());
        }
    }
}
