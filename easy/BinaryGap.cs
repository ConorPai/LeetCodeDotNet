//https://leetcode-cn.com/problems/binary-gap/description/

using System;

public class BinaryGapDemo {
    public int BinaryGap(int N) {
        
        int nMaxGap = 0;
        int nBeginIndex = -1;
        for (int i = 0; i < 32; i++)
        {
            if ((N >> i & 1) == 1)
            {
                if (nBeginIndex == -1)
                    nBeginIndex = i;
                else
                {
                    nMaxGap = Math.Max(nMaxGap, i - nBeginIndex);
                    nBeginIndex = i;
                }
            }
        }

        return nMaxGap;
    }
}