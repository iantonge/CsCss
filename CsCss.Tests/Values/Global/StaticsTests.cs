using CsCss.Values.Global;
using Xunit;

namespace CsCss.Tests.Values.Text.Global
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersInheritKeyword()
        {
            Assert.Equal("inherit", Inherit.ToString());
            Assert.Equal(typeof(GlobalKeyword), Inherit.GetType());
        }

        [Fact]
        public void RendersInitialKeyword()
        {
            Assert.Equal("initial", Initial.ToString());
            Assert.Equal(typeof(GlobalKeyword), Initial.GetType());
        }

        [Fact]
        public void RendersRevertKeyword()
        {
            Assert.Equal("revert", Revert.ToString());
            Assert.Equal(typeof(GlobalKeyword), Revert.GetType());
        }

        [Fact]
        public void RendersUnsetKeyword()
        {
            Assert.Equal("unset", Unset.ToString());
            Assert.Equal(typeof(GlobalKeyword), Unset.GetType());
        }
    }
}
