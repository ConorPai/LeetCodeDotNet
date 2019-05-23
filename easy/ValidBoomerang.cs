//https://leetcode-cn.com/problems/valid-boomerang/

using System;

public class ValidBoomerangDemo {
    public bool IsBoomerang(int[][] points) {
        if (points[0][0] == points[1][0] && points[0][1] == points[1][1])
            return false;
        if (points[0][0] == points[2][0] && points[0][1] == points[2][1])
            return false;
        if (points[2][0] == points[1][0] && points[2][1] == points[1][1])
            return false;

        if (points[0][1] == points[1][1] || points[1][1] == points[2][1] || points[0][1] == points[2][1])
            return points[0][1] != points[1][1] || points[1][1] != points[2][1];

        double da = (double)(points[2][0] - points[1][0]) / (double)(points[2][1] - points[1][1]);
        double db = (double)(points[0][0] - points[1][0]) / (double)(points[0][1] - points[1][1]);

        return Math.Abs(da - db) > 0.000001;
    }
}