//https://leetcode-cn.com/problems/surface-area-of-3d-shapes/description/

using System;

public class SurfaceAreaof3DShapesDemo {
    public int SurfaceArea(int[][] grid) {
        
        int nRetX = 0;
        int nRetY = 0;
        int nRetZ = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] != 0)
                    nRetZ++;

                if (j == 0)
                    nRetY += grid[i][j];
                else
                    nRetY += Math.Abs(grid[i][j] - grid[i][j - 1]);
            }
            nRetY += grid[i][grid[i].Length - 1];
        }

        for (int i = 0; i < grid[0].Length; i++)
        {
            for (int j = 0; j < grid.Length; j++)
            {
                if (j == 0)
                    nRetX += grid[j][i];
                else
                    nRetX += Math.Abs(grid[j][i] - grid[j - 1][i]);
            }
            nRetX += grid[grid.Length - 1][i];
        }

        return  nRetX + nRetY + 2 * nRetZ;
    }
}