//https://leetcode-cn.com/problems/minimum-area-rectangle/

using System;
using System.Collections.Generic;

public class MinimumAreaRectangleDemo {
    public int MinAreaRect(int[][] points) {
        int nMinArea = int.MaxValue;
        Dictionary<int, List<int>> pts = new Dictionary<int, List<int>>();
        for (int i = 0; i < points.Length; i++)
        {
            if (!pts.ContainsKey(points[i][0]))
                pts[points[i][0]] = new List<int>();

            pts[points[i][0]].Add(points[i][1]);
        }

        for (int i = 0; i < points.Length - 1; i++)
        {
            for (int j = i + 1; j < points.Length; j++)
            {
                if (points[i][0] != points[j][0] && points[i][1] != points[j][1]
                    && pts[points[i][0]].Contains(points[j][1]) && pts[points[j][0]].Contains(points[i][1]))
                {
                    int area = Math.Abs(points[j][0] - points[i][0]) * Math.Abs(points[j][1] - points[i][1]);
                    nMinArea = Math.Min(nMinArea, area);
                }
            }
        }

        return nMinArea == int.MaxValue ? 0 : nMinArea;
    }
}