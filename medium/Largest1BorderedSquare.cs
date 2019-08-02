//https://leetcode-cn.com/problems/largest-1-bordered-square/

using System;

public class Largest1BorderedSquareDemo {
    private bool Is1BorderedSquare(int[][] grid, int row, int col, int length)
    {
        for (int i = 0; i < length; i++)
        {
            if (grid[row + i][col] == 0) return false;
            if (grid[row][col + i] == 0) return false;
            if (grid[row + i][col + length - 1] == 0) return false;
            if (grid[row + length - 1][col + i] == 0) return false;
        }

        return true;
    }
    public int Largest1BorderedSquare(int[][] grid) {
        int nRowLength = grid.Length;
        int nColLength = grid[0].Length;
        int length = Math.Min(nRowLength, nColLength);

        while (length > 0)
        {
            for (int i = 0; i <= grid.Length - length; i++)
            {
                for (int j = 0; j <= grid[0].Length - length; j++)
                {
                    if (Is1BorderedSquare(grid, i, j, length))
                        return length * length;
                }
            }

            length--;
        }

        return 0;
    }
}