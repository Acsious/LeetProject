namespace LeetProject;

public static class P860
{
    /// <summary>
    /// Lemonade Change (EASY)
    /// </summary>
    /// <param name="bills"></param>
    /// <returns></returns>
    public static bool LemonadeChange(int[] bills)
    {
        Dictionary<int, int> billsMap = new()
        {
            { 5, 0},
            { 10, 0}
        };
        foreach (int bill in bills)
        {
            if (bill == 5)
            { 
                billsMap[5]++;
                continue;
            }
            if (bill == 10)
            {
                if (billsMap[5] > 0)
                {
                    billsMap[5]--;
                    billsMap[10]++;
                    continue;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (billsMap[5] <= 0)
                {
                    return false;
                }
                else
                {
                    if (billsMap[10] > 0)
                    {
                        billsMap[5]--;
                        billsMap[10]--;
                        continue;
                    }
                    else if (billsMap[5] > 2)
                    {
                        billsMap[5] -= 3;
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        return true;
    }
}
