//https://leetcode-cn.com/problems/fair-candy-swap/description/

using System;
using System.Collections.Generic;

public class FairCandySwapDemo {
    public int[] FairCandySwap(int[] A, int[] B) {
        
        int nACount = 0;
        foreach (int a in A)
            nACount += a;

        int nBCount = 0;
        SortedSet<int> listB = new SortedSet<int>();
        foreach (int b in B)
        {
            nBCount += b;
            listB.Add(b);
        }

        int nEachCount = (nACount + nBCount) / 2;
        
        foreach (int a in A)
        {
            int num = nEachCount - nACount + a;
            if (listB.Contains(num))
                return new int[]{a, num};
        }

        return A;
    }
}