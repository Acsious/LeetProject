namespace LeetProject
{
    public static class P13
    {
        /// <summary>
        /// Roman to Integer (Easy)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> numbers = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            var length = s.Length;
            var result = 0;
            for (int i = 0; i < length; i++)
            {
                if (i < length - 1 && numbers[s[i]] < numbers[s[i + 1]])
                {
                    result += numbers[s[i + 1]] - numbers[s[i]];
                    i++;
                }
                else
                    result += numbers[s[i]];
            }
            return result;
        }
    }
}
