namespace LeetProject;

public static class P29
{
    /// <summary>
    /// TODO:  Divide Two Integers (Medium)
    /// </summary>
    /// <param name="dividend"></param>
    /// <param name="divisor"></param>
    /// <returns></returns>
    public static int Divide(int dividend, int divisor)
    {

        if ((dividend > 0 && divisor > 0) || (dividend < 0 && divisor < 0))
        {
            if (divisor < 0)
            {
                divisor = Math.Abs(divisor);
                dividend = Math.Abs(dividend);
            }
            Console.WriteLine(DivideHelper(dividend, divisor));
            return DivideHelper(dividend, divisor);
        }
        else
        {
            divisor = Math.Abs(divisor);
            dividend = Math.Abs(dividend);
            Console.WriteLine(DivideHelper(dividend, divisor) * (-1));
            return DivideHelper(dividend, divisor) * (-1);
        }
    }
    private static int DivideHelper(int dividend, int divisor)
    {
        int result = 0;
        while (dividend >= 0)
        {
            dividend -= divisor;
            result++;
        }
        if (dividend < 0)
            return result - 1;
        else
            return result;
    }
}
