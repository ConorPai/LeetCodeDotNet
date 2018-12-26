//https://leetcode-cn.com/problems/minimum-falling-path-sum/

using System;

public class MinimumFallingPathSumDemo {
    public int MinFallingPathSum(int[][] A) {
        int ret = Int32.MaxValue;

        int[][] minValue = new int[A.Length][];
        for (int i = 0; i < A.Length; i++)
        {
            minValue[i] = new int[A[0].Length];
            for (int j = 0; j < A[0].Length; j++)
                minValue[i][j] = Int32.MaxValue;
        }
        for (int i = 0; i < A[0].Length; i++)
            ret = Math.Min(ret, minFalling(A, 0, i, minValue));

        return ret;
    }

    private int minFalling(int[][] A, int row, int column, int[][] minValue)
    {
        if (column < 0 || column >= A[0].Length)
            return Int32.MaxValue;

        if (minValue[row][column] != Int32.MaxValue)
            return minValue[row][column];

        if (row == A.Length - 1)
            return A[row][column];

        int value = Int32.MaxValue;

        value = Math.Min(value, minFalling(A, row + 1, column - 1, minValue));
        value = Math.Min(value, minFalling(A, row + 1, column, minValue));
        value = Math.Min(value, minFalling(A, row + 1, column + 1, minValue));

        minValue[row][column] = value + A[row][column];
        return minValue[row][column];
    }
}