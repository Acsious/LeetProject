namespace LeetProject;

public static class P15
{
    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        var set = new List<IList<int>>();
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            int l = i + 1;
            int r = nums.Length - 1;
            int k = -nums[i];
            while (l < r)
            {
                if (nums[l] + nums[r] == k)
                {
                    set.Add(new List<int> { nums[i], nums[l], nums[r] });

                    while (l < r && nums[l] == nums[l + 1])
                    {
                        l++;
                    }
                    l++;
                    r--;
                }
                else if (nums[l] + nums[r] > k)
                {
                    r--;
                }
                else
                {
                    l++;
                }
            }
        }
        return set;
    }
}
