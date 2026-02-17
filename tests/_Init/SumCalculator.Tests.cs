namespace AlgoPlayground._Init;

public class SumCalculatorTests
{
    [Fact]
    public void Sum_ReturnsExpectedTotal()
    {
        var result = SumCalculator.Sum(5, 10, -3);
        Assert.Equal(12, result);
    }

    [Fact]
    public void Sum_WithNoNumbers_ReturnsZero()
    {
        var result = SumCalculator.Sum();
        Assert.Equal(0, result);
    }
}
