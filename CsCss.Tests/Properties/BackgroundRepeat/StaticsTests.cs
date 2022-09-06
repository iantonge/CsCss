using CsCss.Properties.BackgroundRepeat;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundRepeat
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersBackgroundRepeat()
        {
            Assert.Equal("background-repeat", Keywords.BackgroundRepeat.ToString());
            Assert.Equal(typeof(BackgroundRepeatProperty), Keywords.BackgroundRepeat.GetType());
        }
    }
}
