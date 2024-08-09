namespace LeetProject;

public static class P122
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="prices"></param>
    /// <returns></returns>
    public static int MaxProfit(int[] prices)
    {
        int actual = prices[0];
        int sum = 0;
        foreach (var price in prices)
        {
            if (actual < price)
            {
                sum += price - actual;
                actual = price;
            }
            else if (actual > price)
            {
                actual = price;
            }
        }
        return sum;
    }
}
