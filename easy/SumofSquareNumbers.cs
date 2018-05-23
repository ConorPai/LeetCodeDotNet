//https://leetcode-cn.com/problems/sum-of-square-numbers/description/

using System;

public class SumofSquareNumbersDemo {
    public bool JudgeSquareSum(int c) {
        int nLeft = 0;
        int nRight = (int)Math.Sqrt(c);

        while (nLeft <= nRight)
        {
            if (nLeft * nLeft + nRight * nRight < c)
                nLeft++;
            else if (nLeft * nLeft + nRight * nRight > c)
                nRight--;
            else
                return true;
        }

        return false;
    }
}