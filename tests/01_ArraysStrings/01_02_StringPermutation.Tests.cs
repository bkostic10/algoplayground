
namespace AlgoPlayground._01_ArraysStrings;

public class _01_02_StringPermutationTests
{

    [Theory]
    [InlineData("aa", "aa")]
    public void AreStringsPermutation_ReturnsTrue_WhenSameStrings(string input1, string input2)
    {
        var result = _01_02_StringPermutation.AreTwoStringsPermutation(input1, input2);
        Assert.True(result);
    }

    [Theory]
    [InlineData("aa", "bb")]
    public void AreStringsPermutation_ReturnsFalse_WhenDifferentStrings(string input1, string input2)
    {
        var result = _01_02_StringPermutation.AreTwoStringsPermutation(input1, input2);
        Assert.False(result);
    }

    [Theory]
    [InlineData("aa", "a")]
    public void AreStringsPermutation_ReturnsFalse_WhenDifferentLengths(string input1, string input2)
    {
        var result = _01_02_StringPermutation.AreTwoStringsPermutation(input1, input2);
        Assert.False(result);
    }

    [Fact]
    public void AreStringsPermutation_Throws_WhenInput1IsNull()
    {
        Assert.Throws<ArgumentNullException>(() => _01_02_StringPermutation.AreTwoStringsPermutation(null!, "abc"));
    }

    [Fact]
    public void AreStringsPermutation_Throws_WhenInput2IsNull()
    {
        Assert.Throws<ArgumentNullException>(() => _01_02_StringPermutation.AreTwoStringsPermutation("abc", null!));
    }
}
