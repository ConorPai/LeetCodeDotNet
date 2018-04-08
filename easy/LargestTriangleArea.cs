//https://leetcode-cn.com/problems/largest-triangle-area/description/

//三个点组成的三角形，可以使用三个点的横纵轴进行分割，分别求分割出来的面积再做加和
//例如三个点(X1,Y1)，(X2,Y2)，(X3,Y3)
//三个三角形面积((X1-X2)*(Y1-Y3) + (X3-X1)*(Y1-Y3) + (X3-X1)*(Y3-Y2)) * 0.5
//即((X1-X2)*(Y1-Y3) + (X3-X1)*(Y1-Y2)) * 0.5
using System;

public class LargestTriangleAreaDemo {
    private double CalcArea(int[] pt1, int[] pt2, int[] pt3)
    {
        return Math.Abs(((pt1[0] - pt2[0]) * (pt1[1] - pt3[1]) + (pt3[0] - pt1[0]) * (pt1[1] - pt2[1])) * 0.5);
    }
    public double LargestTriangleArea(int[][] points) {
        
        if (points.Length < 3)
            return 0.0;
        
        double dMaxArea = 0.0;
        for (int i = 0; i < points.Length; i++)
            for (int j = i + 1; j < points.Length; j++)
                for (int k = j + 1; k < points.Length; k++)
                    dMaxArea = Math.Max(dMaxArea, CalcArea(points[i], points[j], points[k]));

        return dMaxArea;
    }
}