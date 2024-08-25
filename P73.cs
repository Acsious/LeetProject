namespace LeetProject;

public static class P73
{
    public static void SetZeroes(int[][] matrix)
    {
        bool resetRow = matrix[0].Contains(0);
        bool resetCol = false;
        for (int i = 0; i < matrix.Length; i++)
        {
            if (matrix[i][0] == 0)
            {
                resetCol = true;
            }
        }
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    matrix[0][j] = 0;
                    matrix[i][0] = 0;
                }
            }
        }

        for (int i = 1; i < matrix.Length; i++)
        {
            for (int j = 1; j < matrix[i].Length; j++)
            {
                if (matrix[i][0] == 0 || matrix[0][j] == 0)
                {
                    matrix[i][j] = 0;
                }
            }
        }
        if (resetRow)
        {
            for (int i = 0; i < matrix[0].Length; i++)
            {
                matrix[0][i] = 0;
            }
        }
        if (resetCol)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i][0] = 0;
            }
        }
    }
}
