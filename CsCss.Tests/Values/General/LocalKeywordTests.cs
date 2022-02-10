using CsCss.Values.General;
using Xunit;

namespace CsCss.Tests.Values.General
{
    public class LocalKeywordTests
    {
        [Fact]
        public void RendersLocalKeyword()
        {
            Assert.Equal("local", Statics.Local.ToString());
            Assert.Equal(typeof(LocalKeyword), Statics.Local.GetType());
        }
    }
}
