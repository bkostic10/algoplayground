namespace AlgoPlayground._01_ArraysStrings;

public static class _01_02a_StringPalindrome
{
    public static bool IsStringPalindrome(string input1)
    {
        ArgumentNullException.ThrowIfNull(input1);   

        string input = input1.ToLower().Replace(" ", string.Empty);

        for (int i = 0, j = input.Length - 1; i < j; i++, j--)
        {
            if (input[i] != input[j])
            {
                return false;
            }
        }

        return true;
        
    }
}
