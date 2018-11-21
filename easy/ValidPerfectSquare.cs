//https://leetcode-cn.com/problems/valid-perfect-square/

using System;

public class ValidPerfectSquareDemo {
    public bool IsPerfectSquare(int num) {
        if (num == 1)
            return true;

        Int64 nStart = 1;
        Int64 nEnd = num / 2;

        while (nStart < nEnd)
        {
            if (nStart == nEnd - 1)
                return nStart * nStart == num || nEnd * nEnd == num;

            Int64 mid = (nStart + nEnd) / 2;
            Int64 squa = mid * mid;

            if (squa < num)
                nStart = mid;
            else if (squa > num)
                nEnd = mid;
            else
                return true;
        }

        return false;
    }
}