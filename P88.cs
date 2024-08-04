namespace LeetProject;

public static class P88
{
    /// <summary>
    /// Merge Sorted Array (Easy)
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="m"></param>
    /// <param name="nums2"></param>
    /// <param name="n"></param>
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (n == 0) return;
        int len1 = nums1.Length;
        int end_idx = len1 - 1;
        while (n > 0 && m > 0)
        {
            if (nums2[n - 1] >= nums1[m - 1])
            {
                nums1[end_idx] = nums2[n - 1];
                n--;
            }
            else
            {
                nums1[end_idx] = nums1[m - 1];
                m--;
            }
            end_idx--;
        }
        while (n > 0)
        {
            nums1[end_idx] = nums2[n - 1];
            n--;
            end_idx--;
        }
        foreach (int x in nums1)
            Console.WriteLine(x);
    }
}
