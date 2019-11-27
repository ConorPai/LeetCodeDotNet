//https://leetcode-cn.com/problems/shift-2d-grid/

using System.Collections.Generic;

public class Shift2DGridDemo {
    public IList<IList<int>> ShiftGrid(int[][] grid, int k) {
        int n = grid.Length;
        int m = grid[0].Length;
        int ttl = n * m;

        IList<IList<int>> res = new List<IList<int>>();

        for(int i = (ttl - k % ttl) % ttl, j = 0; j < ttl; j++, i=(++i) % ttl)
        {
            if(j % m == 0)
                res.Add(new List<int>());

            res[res.Count - 1].Add(grid[i / m][i % m]);
        }

        return res;
    }
}