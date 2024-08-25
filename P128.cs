namespace LeetProject
{
    public static class P128
    {
        public static int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
            Array.Sort(nums);
            int result = 1, currentSum = 1;
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (Math.Abs(Math.Abs(nums[i+1]) - Math.Abs(nums[i])) == 1)
                {
                    currentSum++;
                }
                else
                {
                    if (currentSum > result)
                    {
                        result = currentSum;
                        currentSum = 1;
                    }
                }
            }
            return result;
        }
    }
}
