using CsCss.Properties.BackgroundRepeat;
using Xunit;

namespace CsCss.Tests.Properties.BackgroundRepeat
{
    public class StaticsTests
    {
        [Fact]
        public void RendersBackgroundRepeat()
        {
            Assert.Equal("background-repeat", Statics.BackgroundRepeat.ToString());
            Assert.Equal(typeof(BackgroundRepeatProperty), Statics.BackgroundRepeat.GetType());
        }
    }
}
