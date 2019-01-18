//https://leetcode-cn.com/problems/k-closest-points-to-origin/

using System;
using System.Linq;
using System.Collections.Generic;

public class KClosestPointstoOriginDemo {
    public int[][] KClosest(int[][] points, int K) {
        Dictionary<int, List<int>> diss = new Dictionary<int, List<int>>();

        for (int i = 0; i < points.Length; i++)
        {
            int dis = (int)(Math.Pow(points[i][0], 2) + Math.Pow(points[i][1], 2));

            if (!diss.ContainsKey(dis))
                diss[dis] = new List<int>();

            diss[dis].Add(i);
        }

        int[][] result = new int[K][];
        int index = 0;

        var dicSort = from objDic in diss orderby objDic.Key select objDic;
        foreach(KeyValuePair<int, List<int>> kvp in dicSort)
        {
            for (int i = 0; i < kvp.Value.Count; i++)
            {
                result[index++] = points[kvp.Value[i]];
                if (index >= K)
                    break;
            }
                if (index >= K)
                    break;
        }

        return result;
    }
}