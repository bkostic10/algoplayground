namespace AlgoPlayground._01_ArraysStrings;

public static class _01_01_AllUniuqueChars
{
    // Main variant: works for any Unicode string.
    public static bool HasAllUniqueChars(string value)
    {
        ArgumentNullException.ThrowIfNull(value);

        var seen = new HashSet<char>();
        foreach (var ch in value)
        {
            if (!seen.Add(ch))
            {
                return false;
            }
        }

        return true;
    }

    // Optional variant when input is constrained to ASCII.
    public static bool HasAllUniqueAsciiChars(string value)
    {
        ArgumentNullException.ThrowIfNull(value);

        if (value.Length > 128)
        {
            return false;
        }

        Span<bool> seen = stackalloc bool[128];

        foreach (var ch in value)
        {
            if (ch > 127)
            {
                return false;
            }

            if (seen[ch])
            {
                return false;
            }

            seen[ch] = true;
        }

        return true;
    }
}
