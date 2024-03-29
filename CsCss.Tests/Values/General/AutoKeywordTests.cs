﻿using CsCss.Values.General;
using CsCss.Values.Sizing;
using System;
using Xunit;

namespace CsCss.Tests.Values.General
{
    public class AutoKeywordTests
    {
        [Fact]
        public void RendersAutoKeyword()
        {
            Assert.Equal("auto", Auto.ToString());
            Assert.Equal(typeof(AutoKeyword), Auto.GetType());
        }
    }
}
