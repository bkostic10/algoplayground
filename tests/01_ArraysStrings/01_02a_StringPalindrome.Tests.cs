
namespace AlgoPlayground._01_ArraysStrings;

public class _01_02a_StringPalindromeTests
{
    [Theory]
    [InlineData("Perarep")]
    [InlineData("anavolimilovana")]
    [InlineData("an a voli milovana")]
    [InlineData("a n a")]
    public void IsStringPalindrome_ReturnsTrue_WhenPalindrome(string input)
    {
        var result = _01_02a_StringPalindrome.IsStringPalindrome(input);
        Assert.True(result);
    }

    [Theory]
    [InlineData("Pera")]
    [InlineData("anavolimilovana1")]
    [InlineData("Pera1")]
    [InlineData("an a voli milovanb")]
    public void IsStringPalindrome_ReturnsFalse_WhenNotPalindrome(string input)
    {
        var result = _01_02a_StringPalindrome.IsStringPalindrome(input);
        Assert.False(result);
    }

    [Fact]
    public void IsStringPalindrome_Throws_WhenInputIsNull()
    {
        Assert.Throws<ArgumentNullException>(() => _01_02a_StringPalindrome.IsStringPalindrome(null!));
    }
}
