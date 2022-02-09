using CsCss.Values.Text.Global;
using Xunit;

namespace CsCss.Tests.Values.Text.Global
{
    public class StaticsTests
    {
        [Fact]
        public void RendersInheritKeyword()
        {
            Assert.Equal("inherit", Statics.Inherit.ToString());
            Assert.Equal(typeof(GlobalKeyword), Statics.Inherit.GetType());
        }

        [Fact]
        public void RendersInitialKeyword()
        {
            Assert.Equal("initial", Statics.Initial.ToString());
            Assert.Equal(typeof(GlobalKeyword), Statics.Initial.GetType());
        }

        [Fact]
        public void RendersRevertKeyword()
        {
            Assert.Equal("revert", Statics.Revert.ToString());
            Assert.Equal(typeof(GlobalKeyword), Statics.Revert.GetType());
        }

        [Fact]
        public void RendersUnsetKeyword()
        {
            Assert.Equal("unset", Statics.Unset.ToString());
            Assert.Equal(typeof(GlobalKeyword), Statics.Unset.GetType());
        }
    }
}
