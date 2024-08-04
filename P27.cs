namespace LeetProject;

public static class P27
{
    /// <summary>
    /// Remove element (Easy)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="val"></param>
    /// <returns>number of non deleted items</returns>
    public static int RemoveElement(int[] nums, int val)
    {
        int k = 0;
        foreach (var item in nums)
        {
            if (item != val)
            {
                nums[k] = item;
                k++;
            }
        }
        return k;
    }
}
