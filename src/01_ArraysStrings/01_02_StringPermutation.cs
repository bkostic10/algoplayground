namespace AlgoPlayground._01_ArraysStrings;

public static class _01_02_StringPermutation
{
    public static bool AreTwoStringsPermutation(string input1, string input2)
    {
        ArgumentNullException.ThrowIfNull(input1);
        ArgumentNullException.ThrowIfNull(input2);

        if(input1.Length != input2.Length)
        {
            return false;
        }
        
        Dictionary<char, int> charCount1 = [];
        Dictionary<char, int> charCount2 = [];

        foreach (char c in input1)
        {
            if (charCount1.TryGetValue(c, out int value))
            {
                charCount1[c] = ++value;
            }
            else
            {
                charCount1[c] = 1;
            }
        }
        foreach (char c in input2)
        {
            if (charCount2.TryGetValue(c, out int value))
            {
                charCount2[c] = ++value;
            }
            else
            {
                charCount2[c] = 1;
            }
        }

        foreach (var kvp in charCount1)
        {
            if (!charCount2.TryGetValue(kvp.Key, out int value) || value != kvp.Value)
            {
                return false;
            }
        }

        return true;
    }
}
