namespace AlgoPlayground._01_ArraysStrings;

public class _01_01_AllUniuqueCharsTests
{
    [Theory]
    [InlineData("")]
    [InlineData("abc")]
    [InlineData("AaBbCc")]
    public void HasAllUniqueChars_ReturnsTrue_WhenAllCharsAreUnique(string input)
    {
        var result = _01_01_AllUniuqueChars.HasAllUniqueChars(input);
        Assert.True(result);
    }

    [Theory]
    [InlineData("aa")]
    [InlineData("abca")]
    [InlineData("1123")]
    public void HasAllUniqueChars_ReturnsFalse_WhenAnyCharRepeats(string input)
    {
        var result = _01_01_AllUniuqueChars.HasAllUniqueChars(input);
        Assert.False(result);
    }

    [Fact]
    public void HasAllUniqueChars_Throws_WhenInputIsNull()
    {
        Assert.Throws<ArgumentNullException>(() => _01_01_AllUniuqueChars.HasAllUniqueChars(null!));
    }

    [Theory]
    [InlineData("")]
    [InlineData("abcXYZ")]
    [InlineData("0123456789")]
    public void HasAllUniqueAsciiChars_ReturnsTrue_ForUniqueAsciiInput(string input)
    {
        var result = _01_01_AllUniuqueChars.HasAllUniqueAsciiChars(input);
        Assert.True(result);
    }

    [Theory]
    [InlineData("hello")]
    [InlineData("aA1a")]
    public void HasAllUniqueAsciiChars_ReturnsFalse_WhenAsciiInputHasDuplicates(string input)
    {
        var result = _01_01_AllUniuqueChars.HasAllUniqueAsciiChars(input);
        Assert.False(result);
    }

    [Fact]
    public void HasAllUniqueAsciiChars_ReturnsFalse_WhenInputContainsNonAsciiChars()
    {
        var result = _01_01_AllUniuqueChars.HasAllUniqueAsciiChars("abCz\u00e9");
        Assert.False(result);
    }

    [Fact]
    public void HasAllUniqueAsciiChars_ReturnsFalse_WhenLengthExceedsAsciiSet()
    {
        var input = new string(Enumerable.Range(0, 129).Select(i => (char)i).ToArray());

        var result = _01_01_AllUniuqueChars.HasAllUniqueAsciiChars(input);

        Assert.False(result);
    }

    [Fact]
    public void HasAllUniqueAsciiChars_Throws_WhenInputIsNull()
    {
        Assert.Throws<ArgumentNullException>(() => _01_01_AllUniuqueChars.HasAllUniqueAsciiChars(null!));
    }
}
