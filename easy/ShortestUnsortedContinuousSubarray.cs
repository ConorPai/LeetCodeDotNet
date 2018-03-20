//https://leetcode.com/problems/shortest-unsorted-continuous-subarray/description/

using System.Collections.Generic;

public class ShortestUnsortedContinuousSubarrayDemo {
    public int FindUnsortedSubarray(int[] nums) {
        List<int> listNums = new List<int>(nums);
        listNums.Sort();

        int nMinDefIndex = -1;
        int nMaxDefIndex = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != listNums[i])
            {
                nMinDefIndex = i;
                break;
            }
        }

        if (nMinDefIndex == -1)
            return 0;

        for (int i = nums.Length - 1; i >= nMinDefIndex; i--)
        {
            if (nums[i] != listNums[i])
            {
                nMaxDefIndex = i;
                break;
            }
        }

        return nMaxDefIndex - nMinDefIndex + 1;
    }
}