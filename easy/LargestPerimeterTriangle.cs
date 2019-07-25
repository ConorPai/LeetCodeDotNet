//https://leetcode-cn.com/problems/largest-perimeter-triangle/

using System;

public class LargestPerimeterTriangleDemo {
    public int LargestPerimeter(int[] A) {
        Array.Sort(A);

        for (int i = A.Length - 3; i >= 0; i--)
        {
            if (A[i] + A[i + 1] > A[i + 2])
                return A[i] + A[i + 1] + A[i + 2];
        }

        return 0;
    }
}