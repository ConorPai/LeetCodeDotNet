//https://leetcode-cn.com/problems/range-addition-ii/

using System;

class RangeAdditionIIDemo {
    public int maxCount(int m, int n, int[][] ops) {
        if (ops == null || ops.Length == 0)
            return m * n;

        int nX = Int32.MaxValue;
        int nY = Int32.MaxValue;

        for (int i = 0; i < ops.Length; i++)
        {
            if (ops[i][0] < nX)
                nX = ops[i][0];
            if (ops[i][1] < nY)
                nY = ops[i][1];
        }

        return nX * nY;
    }
}