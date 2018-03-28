//https://leetcode-cn.com/problems/max-increase-to-keep-city-skyline/description/

public class MaxIncreasetoKeepCitySkylineDemo {
    public int MaxIncreaseKeepingSkyline(int[][] grid) {
        
        int[] tb = new int[grid.Length];
        int[] lr = new int[grid[0].Length];

        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid[0].Length; j++)
                tb[i] = System.Math.Max(tb[i], grid[i][j]);

        
        for (int i = 0; i < grid[0].Length; i++)
            for (int j = 0; j < grid.Length; j++)
                lr[i] = System.Math.Max(lr[i], grid[j][i]);

        int nRet = 0;
        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid[0].Length; j++)
                nRet += System.Math.Min(tb[i], lr[j]) - grid[i][j];

        return nRet;
    }
}