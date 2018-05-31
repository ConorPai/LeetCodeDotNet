//https://leetcode-cn.com/problems/magic-squares-in-grid/description/

public class MagicSquaresInGridDemo {
    public int NumMagicSquaresInside(int[][] grid) {
        int nRet = 0;
        for (int i = 1; i < grid.Length - 1; i++)
            for (int j = 1; j < grid[i].Length - 1; j++)
            {
                if (grid[i][j] == 5 && IsMagicSquares(grid, i, j))
                    nRet++;
            }

        return nRet;
    }

    private bool IsMagicSquares(int[][] grid, int row, int col)
    {
        for (int i = row - 1; i <= row + 1; i++)
            for (int j = col - 1; j <= col + 1; j++)
                if (grid[i][j] < 1 || grid[i][j] > 9)
                    return false;
        
        if (grid[row - 1][col - 1] + grid[row + 1][col + 1] != 10)
            return false;
        
        if (grid[row - 1][col] + grid[row + 1][col] != 10)
            return false;

        if (grid[row - 1][col + 1] + grid[row + 1][col - 1] != 10)
            return false;
        
        if (grid[row][col - 1] + grid[row][col + 1] != 10)
            return false;

        return true;
    }
}