//https://leetcode-cn.com/problems/projection-area-of-3d-shapes/description/

using System;

public class ProjectionAreaof3DShapesDemo {
    public int ProjectionArea(int[][] grid) {
        
        int nRetX = 0;
        int nRetY = 0;
        int nRetZ = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            int nMax = 0;
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] != 0)
                    nRetZ++;

                nMax = Math.Max(nMax, grid[i][j]);
            }

            nRetY += nMax;
        }

        for (int i = 0; i < grid[0].Length; i++)
        {
            int nMax = 0;
            for (int j = 0; j < grid.Length; j++)
            {
                nMax = Math.Max(nMax, grid[j][i]);
            }

            nRetX += nMax;
        }

        return nRetX + nRetY + nRetZ;
    }
}