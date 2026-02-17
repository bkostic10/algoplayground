namespace AlgoPlayground._Init;

public static class SumCalculator
{
    public static int Sum(params int[] numbers)
    {
        ArgumentNullException.ThrowIfNull(numbers);

        checked
        {
            var total = 0;
            foreach (var number in numbers)
            {
                total += number;
            }

            return total;
        }
    }
}
