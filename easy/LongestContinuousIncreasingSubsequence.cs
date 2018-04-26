//https://leetcode-cn.com/problems/longest-continuous-increasing-subsequence/description/

using System;

public class LongestContinuousIncreasingSubsequenceDemo {
    public int FindLengthOfLCIS(int[] nums) {
        if (nums.Length == 0)
            return 0;

        int nMin = nums[0];
        int nMax = 1;
        int nMaxRet = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] <= nMin)
            {
                nMaxRet = Math.Max(nMax, nMaxRet);
                nMax = 1;
            }
            else
                nMax++;

            nMin = nums[i];
        }

        nMaxRet = Math.Max(nMax, nMaxRet);
        return nMaxRet;
    }
}