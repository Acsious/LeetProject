namespace LeetProject;

public static class P26
{
    /// <summary>
    /// Remove Duplicates from Sorted Array (Easy)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns>Num of non duplicate elems</returns>
    public static int RemoveDuplicates(int[] nums)
    {
        int k = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[k] != nums[i])
            {
                nums[++k] = nums[i];
            }
        }
        return k + 1;
    }
}
