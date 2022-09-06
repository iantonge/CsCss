using CsCss.Values.Global;
using Xunit;

namespace CsCss.Tests.Values.Text.Global
{
    public class KeywordsTests
    {
        [Fact]
        public void RendersInheritKeyword()
        {
            Assert.Equal("inherit", Keywords.Inherit.ToString());
            Assert.Equal(typeof(GlobalKeyword), Keywords.Inherit.GetType());
        }

        [Fact]
        public void RendersInitialKeyword()
        {
            Assert.Equal("initial", Keywords.Initial.ToString());
            Assert.Equal(typeof(GlobalKeyword), Keywords.Initial.GetType());
        }

        [Fact]
        public void RendersRevertKeyword()
        {
            Assert.Equal("revert", Keywords.Revert.ToString());
            Assert.Equal(typeof(GlobalKeyword), Keywords.Revert.GetType());
        }

        [Fact]
        public void RendersUnsetKeyword()
        {
            Assert.Equal("unset", Keywords.Unset.ToString());
            Assert.Equal(typeof(GlobalKeyword), Keywords.Unset.GetType());
        }
    }
}
