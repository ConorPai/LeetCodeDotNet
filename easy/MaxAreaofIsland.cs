//https://leetcode.com/problems/max-area-of-island/description/

public class MaxAreaofIslandDemo {
    public int MaxAreaOfIsland(int[,] grid) {
        
        int nMaxArea = 0;
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                if (grid[i, j] == 1)
                    nMaxArea = System.Math.Max(nMaxArea, MaxAreaOfGrid(grid, i, j, grid.GetLength(0), grid.GetLength(1), 0));
            }
        }

        return nMaxArea;
    }

    private int MaxAreaOfGrid(int[,] grid, int row, int col, int rowcount, int colcount, int area)
    {
        if (row < 0 || col < 0 || row >= rowcount || col >= colcount || grid[row, col] == 0)
            return area;

        grid[row, col] = 0;
        area++;

        area = MaxAreaOfGrid(grid, row - 1, col, rowcount, colcount, area);
        area = MaxAreaOfGrid(grid, row + 1, col, rowcount, colcount, area);
        area = MaxAreaOfGrid(grid, row, col - 1, rowcount, colcount, area);
        area = MaxAreaOfGrid(grid, row, col + 1, rowcount, colcount, area);

        return area;
    }
}