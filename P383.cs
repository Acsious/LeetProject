namespace LeetProject;

public static class P383
{
    public static Dictionary<char, int> ransomDictionary = [];
    public static Dictionary<char, int> magazineDictionary = [];
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        if (ransomNote.Length > magazine.Length) return false;
        foreach (char c in ransomNote)
        {
            if (ransomDictionary.ContainsKey(c))
            {
                ransomDictionary[c]++;
                
            }
            else
            {
                ransomDictionary.Add(c, 1);
            }
        }
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
        foreach (var rD in ransomDictionary)
        {
            if (magazineDictionary.ContainsKey(rD.Key))
            {
                if (magazineDictionary[rD.Key] - rD.Value < 0)
                {
                    return false;
                }
                continue;
            }
            return false;
        }

        return true;
    }
}
