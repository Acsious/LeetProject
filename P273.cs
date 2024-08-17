using System.Text;

namespace LeetProject;

public static class P273
{

    static StringBuilder stringBuilder = new();
    static Dictionary<int, string> hundreds = new()
        {
            { 1, "One Hundred "},
            { 2, "Two Hundred "},
            { 3, "Three Hundred "},
            { 4, "Four Hundred "},
            { 5, "Five Hundred "},
            { 6, "Six Hundred "},
            { 7, "Seven Hundred "},
            { 8, "Eight Hundred "},
            { 9, "Nine Hundred "}
        };
    static Dictionary<int, string> dozens = new()
        {
            { 2, "Twenty "},
            { 3, "Thirty "},
            { 4, "Fourty "},
            { 5, "Fivty "},
            { 6, "Sixty "},
            { 7, "Seventy "},
            { 8, "Eighty "},
            { 9, "Ninety "}
        };
    static Dictionary<int, string> specDozens = new()
        {
            { 0, "Ten " },
            { 1, "Eleven " },
            { 2, "Twelve "},
            { 3, "Thirteen "},
            { 4, "Fourteen "},
            { 5, "Fivteen "},
            { 6, "Sixteen "},
            { 7, "Seventeen "},
            { 8, "Eighteen "},
            { 9, "Nineteen "}
        };
    static Dictionary<int, string> ones = new()
        {
            {1 , "One " },
            {2 ,"Two "},
            {3 ,"Three "},
            {4 ,"Four "},
            {5 ,"Five "},
            {6 ,"Six "},
            {7 ,"Seven "},
            {8 ,"Eight "},
            {9 ,"Nine "},
        };
    /// <summary>
    /// TODO
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public static string NumberToWords(int num)
    {
        if (num == 0) return "Null";

        List<int> chunks = [];
        while (num != 0)
        {
            chunks.Add(num % 1000);
            num /= 1000;
        }

        chunks.Reverse();

        int chunkNumber = chunks.Count;

        foreach (int chunk in chunks)
        {
            stringBuilder.Append(ChunksToWords(chunk, chunkNumber));
            chunkNumber--;
        }
        return stringBuilder.ToString();
    }
    public static string ChunksToWords(int num, int chNum)
    {
        if (num / 100 > 0)
        {
            stringBuilder.Append(hundreds[num / 100]);
        }
        num %= 100;
        if (num / 10 > 1)
        {
            stringBuilder.Append(dozens[num / 10]);
        }
        else if (num / 10 == 1)
        {
            stringBuilder.Append(specDozens[num / 10]);
        }
        else
        {
            stringBuilder.Append(ones[num % 10]);
        }

        switch (chNum)
        {
            case 1:
                break;
            case 2:
                stringBuilder.Append("Thousand ");
                break;
            case 3:
                stringBuilder.Append("Million ");
                break;
            case 4:
                stringBuilder.Append("Trillion ");
                break;
        }
        return stringBuilder.ToString();
    }
}
