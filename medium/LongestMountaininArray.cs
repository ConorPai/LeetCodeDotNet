//https://leetcode-cn.com/problems/longest-mountain-in-array/description/

using System;

public class LongestMountaininArrayDemo {
    public int LongestMountain(int[] A) {
        
        int nMaxMountain = 0;
        int nCurrentMountain = 1;
        int nLastMode = 0;
        for(int i = 1; i < A.Length; i++)
        {
            int nMode = 0;
            if (A[i - 1] < A[i])
                nMode = -1;
            else if (A[i - 1] > A[i])
                nMode = 1;

            if (nLastMode == 0 && nMode == 1)
                continue;

            if (nLastMode == 1 && (nMode == -1 || nMode == 0))
            {
                nMaxMountain = Math.Max(nMaxMountain, nCurrentMountain);
                nCurrentMountain = 1;
            }
            
            if (nMode != 0)
                nCurrentMountain++;
            else
                nCurrentMountain = 1;
            nLastMode = nMode;
        }

        if (nLastMode == 1)
            return Math.Max(nMaxMountain, nCurrentMountain);
        else
            return nMaxMountain;
    }
}