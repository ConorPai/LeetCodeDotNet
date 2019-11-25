//https://leetcode-cn.com/problems/minimum-time-visiting-all-points/
using System;

public class MinimumTimeVisitingAllPointsDemo {
    public int MinTimeToVisitAllPoints(int[][] points) {
        int ans = 0;
        for (int i = 1; i < points.Length; i++)
        {
            int xDiff = points[i][0] - points[i - 1][0];
            int yDiff = points[i][1] - points[i - 1][1];
            ans += Math.Max(Math.Abs(xDiff), Math.Abs(yDiff));
        }
        return ans;
    }
}