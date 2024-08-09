using System.Text;

namespace LeetProject
{
    public static class P392
    {
        /// <summary>
        /// Is Subsequence
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool IsSubsequence(string s, string t)
        {
            if (s.Equals("")) 
            { 
                return true; 
            }
            int i = 0;
            t = t.ToLower();
            s = s.ToLower();
            StringBuilder sb = new();
            foreach (char c in t)
            {
                if (c == s[i])
                {
                    sb.Append(c);
                    i++;
                    if (i == s.Length)
                    {
                        break;
                    }
                }
            }
            return sb.ToString().Equals(s);
        }
    }
}
