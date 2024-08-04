namespace LeetProject;

public static class P80
{
    /// <summary>
    /// Remove Duplicates from Sorted Array II (Medium)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns>Num of non duplicate elems</returns>
    public static int RemoveDuplicates(int[] nums)
    {
        var replaceIndex = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (replaceIndex - 2 >= 0 && nums[replaceIndex - 2] == nums[i])
            {
                continue;
            }
            nums[replaceIndex] = nums[i];
            replaceIndex++;
        }
        return replaceIndex;
    }
}
