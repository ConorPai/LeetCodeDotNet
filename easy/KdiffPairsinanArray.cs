//https://leetcode-cn.com/problems/k-diff-pairs-in-an-array/

using System;
using System.Collections.Generic;

public class KdiffPairsinanArrayDemo {
    public int FindPairs(int[] nums, int k) {
        if (nums == null || nums.Length == 0 || k < 0)
            return 0;
        
        Array.Sort(nums);

        int nLastValue = Int32.MinValue;
        int nCount = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == nLastValue)
                continue;

            int j = i + 1;
            while (j < nums.Length)
            {
                if (nums[j] - nums[i] == k)
                {
                    nCount++;
                    break;
                }

                if (nums[j] - nums[i] > k)
                    break;

                j++;
            }

            nLastValue = nums[i];
        }

        return nCount;
    }
}