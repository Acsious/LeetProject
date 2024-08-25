namespace LeetProject;

public static class P383
{
    public static Dictionary<char, int> magazineDictionary = [];
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        if (ransomNote.Length > magazine.Length) return false;

        foreach (char c in magazine)
        {
            if (magazineDictionary.ContainsKey(c))
            {
                magazineDictionary[c]++;
            }
            else
            {
                magazineDictionary.Add(c, 1);
            }
        }
        foreach (var rN in ransomNote)
        {
            if (magazineDictionary.ContainsKey(rN))
            {
                if (magazineDictionary[rN] == 0) return false;
                magazineDictionary[rN]--;
            }
            else
            {
                return false; 
            }
        }

        return true;
    }
}
