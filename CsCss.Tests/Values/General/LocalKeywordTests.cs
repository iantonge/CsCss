using CsCss.Values.General;
using Xunit;

namespace CsCss.Tests.Values.General
{
    public class LocalKeywordTests
    {
        [Fact]
        public void RendersLocalKeyword()
        {
            Assert.Equal("local", Keywords.Local.ToString());
            Assert.Equal(typeof(LocalKeyword), Keywords.Local.GetType());
        }
    }
}
