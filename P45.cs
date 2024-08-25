namespace LeetProject;

public static class P45
{
    public static int Jump(int[] nums)
    {
        int jumps = 0, curEnd = 0, curFarthest = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            curFarthest = Math.Max(curFarthest, i + nums[i]);
            if (i == curEnd)
            {
                jumps++;
                curEnd = curFarthest;
            }
        }
        return jumps;
    }
}
