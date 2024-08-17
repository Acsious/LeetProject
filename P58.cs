namespace LeetProject;

public static class P58
{
    public static int LengthOfLastWord(string s)
    {
        if (s.Length == 1) return 1;
        var length = 1;
        for (var i = s.Length - 2; i >= 0; i--)
        {
            if (Char.IsLetter(s[i]) && Char.IsLetter(s[i + 1]))
            {
                length++;
            }
            else if (s[i] == ' ' && Char.IsLetter(s[i + 1]))
            {
                break;
            }
        }
        return length;
    }
}
