namespace AlgoPlayground._Init;

public static class Program
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            var sample = SumCalculator.Sum(1, 2, 3, 4);
            Console.WriteLine($"Sample sum for (1, 2, 3, 4): {sample}");
            Console.WriteLine("Pass integers as arguments to test your own scenario.");
            return;
        }

        var numbers = new int[args.Length];

        for (var i = 0; i < args.Length; i++)
        {
            if (!int.TryParse(args[i], out numbers[i]))
            {
                Console.Error.WriteLine($"Invalid integer argument: '{args[i]}'");
                Environment.ExitCode = 1;
                return;
            }
        }

        Console.WriteLine(SumCalculator.Sum(numbers));
    }
}
