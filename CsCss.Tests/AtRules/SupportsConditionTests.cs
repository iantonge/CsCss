using System;
using Xunit;

namespace CsCss.Tests.AtRules;

public class SupportsConditionTests
{
    [Fact]
    public void RendersDeclarationCondition()
    {
        var condition = Supports.Declaration(new()
        {
            [Color] = Red
        });

        Assert.Equal("(color: red)", condition.ToString());
    }

    [Fact]
    public void RendersLengthDeclarationCondition()
    {
        var condition = Supports.Declaration(new()
        {
            [Height] = 10.Px()
        });

        Assert.Equal("(height: 10px)", condition.ToString());
    }

    [Fact]
    public void RendersNegatedCondition()
    {
        var condition = !Supports.Declaration(new()
        {
            [Color] = Red
        });

        Assert.Equal("not (color: red)", condition.ToString());
    }

    [Fact]
    public void RendersAndCondition()
    {
        var condition = Supports.Declaration(new()
        {
            [Color] = Red
        }) & Supports.Declaration(new()
        {
            [Height] = 10.Px()
        });

        Assert.Equal("(color: red) and (height: 10px)", condition.ToString());
    }

    [Fact]
    public void RendersOrCondition()
    {
        var condition = Supports.Declaration(new()
        {
            [Color] = Red
        }) | Supports.Declaration(new()
        {
            [Height] = 10.Px()
        });

        Assert.Equal("(color: red) or (height: 10px)", condition.ToString());
    }

    [Fact]
    public void RejectsEmptyDeclarationCondition()
    {
        Assert.Throws<ArgumentException>(() => Supports.Declaration(new()));
    }

    [Fact]
    public void RejectsMultipleDeclarationCondition()
    {
        Assert.Throws<ArgumentException>(() => Supports.Declaration(new()
        {
            [Color] = Red,
            [Height] = 10.Px()
        }));
    }
}
