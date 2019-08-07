//https://leetcode-cn.com/problems/complement-of-base-10-integer/

using System;

public class ComplementofBase10IntegerDemo {
    public int BitwiseComplement(int N) {
        if (N == 0)
            return 1;
        int nRet = 0;

        int pow = 0;
        while (N > 0)
        {
            int n = N % 2;
            nRet += (int)Math.Pow(2, pow++) * (n == 1 ? 0 : 1);
            N /= 2;
        }

        return nRet;
    }
}