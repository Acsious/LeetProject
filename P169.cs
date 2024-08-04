namespace LeetProject;

public static class P169
{
    public static int MajorityElement(int[] nums)
    {
        GC.Collect();
        Array.Sort(nums);
        return nums[nums.Length / 2];
    }
}
