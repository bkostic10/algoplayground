namespace AlgoPlayground._01_ArraysStrings;

public static class _01_02_StringPermutation
{
    public static bool AreTwoStringsPermutation(string input1, string input2)
    {
        ArgumentNullException.ThrowIfNull(input1);
        ArgumentNullException.ThrowIfNull(input2);

        if (input1.Length != input2.Length)
        {
            return false;
        }

        if (input1.Length == 0)
        {
            return true;
        }

        Dictionary<char, int> charCounts = [];

        foreach (var ch in input1)
        {
            charCounts[ch] = charCounts.TryGetValue(ch, out var count) ? count + 1 : 1;
        }

        foreach (var ch in input2)
        {
            if (!charCounts.TryGetValue(ch, out var count))
            {
                return false;
            }

            if (count == 1)
            {
                charCounts.Remove(ch);
                continue;
            }

            charCounts[ch] = count - 1;
        }

        return charCounts.Count == 0;
    }
}
