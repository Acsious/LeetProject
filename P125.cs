using System.Text;

namespace LeetProject;

public static class P125
{
    /// <summary>
    /// Valid Palindrome (Easy)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    /// 
    public static bool IsPalindrome(string s)
    {
        s = s.ToLower();

        StringBuilder sb = new();

        foreach (char c in s)
        {
            if (char.IsLetterOrDigit(c))
            {
                sb.Append(c);
            }
        }

        string filteredString = sb.ToString();

        int left = 0, right = filteredString.Length - 1;
        while (left < right)
        {
            if (filteredString[left++] != filteredString[right--])
            {
                return false;
            }
        }

        return true;
    }
}
