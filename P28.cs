namespace LeetProject;

public static class P28
{
    /// <summary>
    ///  Find the Index of the First Occurrence in a String
    /// </summary>
    /// <param name="haystack"></param>
    /// <param name="needle"></param>
    /// <returns>-1 if not exist, or index of first occurrence</returns>
    public static int StrStr(string haystack, string needle)
    {
        if (needle.Length == 0) return -1;

        for (int i = 0; i<haystack.Length-needle.Length+1;i++)
        {
            for (int j = 0; j < needle.Length && i + j < haystack.Length && haystack[j + i] == needle[j]; j++)
            {
                if (j == needle.Length - 1) return i;
            }
        }
        return -1;
    }
}
