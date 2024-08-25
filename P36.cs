namespace LeetProject;

internal class P36
{
    public static bool IsValidSudoku(char[][] board)
    {
        var rows = new HashSet<char>[9];
        var cols = new HashSet<char>[9];
        var squares = new HashSet<char>[9];

        for (int i = 0; i < 9; i++)
        {
            rows[i] = [];
            cols[i] = [];
            squares[i] = [];
        }
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                char currentValue = board[i][j];

                if (currentValue != '.')
                {
                    if (!rows[i].Add(currentValue)) return false;
                    if (!cols[j].Add(currentValue)) return false;
                    int squareIndex = (i / 3) * 3 + (j / 3);
                    if (!squares[squareIndex].Add(currentValue)) return false;
                }
            }
        }
        return true;
    }
}
