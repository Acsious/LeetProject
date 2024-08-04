namespace LeetProject;

public static class P121
{
    /// <summary>
    /// TODO: Best Time to Buy and Sell Stock (Easy)
    /// </summary>
    /// <param name="prices"></param>
    /// <returns></returns>
    public static int MaxProfit(int[] prices)
    {
        int IMax = 0, IMin = 0, ValMax = 0, ValMin = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] >= ValMax && i > IMin)
            {
                ValMax = prices[i];
                IMax = i;
            }
            if (prices[i] < ValMin && i < IMax)
            {

            }
        }
    }
}
