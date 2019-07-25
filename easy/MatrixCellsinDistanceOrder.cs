//https://leetcode-cn.com/problems/matrix-cells-in-distance-order/

using System;
using System.Collections.Generic;

public class MatrixCellsinDistanceOrderDemo {

    public int[][] AllCellsDistOrder(int R, int C, int r0, int c0) {
        SortedDictionary<int, List<int[]>> dict = new SortedDictionary<int, List<int[]>>();

        for (int i = 0; i < R; i++)
        {
            for (int j = 0; j < C; j++)
            {
                int dis = Math.Abs(i - r0) + Math.Abs(j - c0);
                int[] cell = new int[2]{i, j};
                if (!dict.ContainsKey(dis))
                    dict[dis] = new List<int[]>();
                
                dict[dis].Add(cell);
            }
        }

        List<int[]> ret = new List<int[]>();
        foreach (var item in dict.Values)
            ret.AddRange(item);
        
        return ret.ToArray();
    }
}