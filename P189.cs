namespace LeetProject;

public static class P189
{
    /// <summary>
    /// Rotate Array (Medium)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    public static void Rotate(int[] nums, int k)
    {
        k %= nums.Length;
        Array.Reverse(nums);
        Array.Reverse(nums, 0, k);
        Array.Reverse(nums, k, nums.Length - k);
    }
}
