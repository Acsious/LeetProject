namespace LeetProject;

public static class P452
{
    public static int FindMinArrowShots(int[][] points)
    {
        points = points.OrderBy(row => row[0]).ThenBy(col => col[1]).ToArray();
        int result = 1;
        int max = int.MinValue;

        foreach (int[] i in points)
        {
            if (max == int.MinValue)
            {
                max = i[1];
            }
            else
            {
                if (i[0] > max)
                {
                    result++;
                    max = i[1];
                }
                else
                {
                    if (i[1] < max)
                    {
                        max = i[1];
                    }
                }
            }
        }
        return result;
    }
}
