namespace LeetProject;

public static class P14
{
    public static string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0) return "";
        if (strs.Length == 1) return strs[0];
        for (int i = 0; i < strs[0].Length; i++)
        {
            var common = true;

            for (int j = 1; j < strs.Length; j++)
            {
                if (i > strs[j].Length - 1 || strs[j][i] != strs[0][i])
                {
                    common = false;
                    break;
                }
            }

            if (!common) return strs[0].Substring(0, i);
        }
        return strs[0];
    }
}
