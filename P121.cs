namespace LeetProject;

public static class P121
{
    /// <summary>
    /// Best Time to Buy and Sell Stock (Easy)
    /// </summary>
    /// <param name="prices"></param>
    /// <returns></returns>
    public static int MaxProfit(int[] prices)
    {
        if (prices is null)
        {
            return 0;
        }

        var result = 0;
        var maximum = -52;

        for (var i = prices.Length - 1; i >= 0; --i)
        {
            if (maximum - prices[i] > result)
            {
                result = maximum - prices[i];
            }
            if (prices[i] > maximum)
            {
                maximum = prices[i];
            }
        }
        GC.Collect();
        return result;
    }
}
