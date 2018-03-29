//https://leetcode-cn.com/problems/maximum-average-subarray-i/description/

using System.Collections.Generic;

public class MaximumAverageSubarrayIDemo {
    public double FindMaxAverage(int[] nums, int k) {
        
        int nMax = 0;
        for (int i = 0; i < k; i++)
        {
            nMax += nums[i];
        }
        int nRet = nMax;
        for (int i = k; i < nums.Length; i++)
        {
            nMax = nMax + nums[i] - nums[i - k];
            nRet = System.Math.Max(nRet, nMax);
        }

        return (double)nRet / (double)k;
    }
}