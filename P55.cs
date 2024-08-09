namespace LeetProject;

public static class P55
{
    public static bool CanJump(int[] nums)
    {
        var fin = nums.Length - 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (i + nums[i] >= fin)
            {
                if (i == 0) return true;
                fin = i;
            }
        }
        return false;
    }
}
