namespace LeetProject
{
    public static class P167
    {
        /// <summary>
        /// TODO 
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            int sum;
            while (left < right)
            {
                sum = numbers[left] + numbers[right];
                if (sum < target)
                {
                    left++;
                }
                else if (sum > target)
                {
                    right--;
                }
                else
                {
                    return [left + 1, right + 1];
                }
            }
            return [-1, -1];
        }
    }
}
