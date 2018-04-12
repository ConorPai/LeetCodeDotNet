//https://leetcode-cn.com/problems/maximum-subarray/description/

using System;

public class MaximumSubarrayDemo {

    public int MaxSubArray(int[] nums) {
        int nMax = nums[0];
        int nSum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            //只要是负数就不值得累加
            nSum = nSum < 0 ? nums[i] : nSum + nums[i];
            nMax = Math.Max(nMax, nSum);
        }

        return nMax;
    }
}