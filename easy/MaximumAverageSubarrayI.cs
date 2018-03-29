//https://leetcode-cn.com/problems/maximum-average-subarray-i/description/

using System.Collections.Generic;

public class MaximumAverageSubarrayIDemo {
    public double FindMaxAverage(int[] nums, int k) {
        
        int nMax = 0;
        for (int i = 0; i < k - 1; i++)
        {
            nMax += nums[i];
        }
        List<int> max = new List<int>();
        for (int i = k - 1; i < nums.Length; i++)
        {
            nMax += nums[i];
            max.Add(nMax);
            nMax -= nums[i - k + 1];
        }

        max.Sort();

        return (double)max[max.Count - 1] / (double)k;
    }
}