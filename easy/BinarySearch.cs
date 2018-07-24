//https://leetcode-cn.com/problems/binary-search/description/

using System;

public class BinarySearchDemo {
    public int Search(int[] nums, int target) {
        return Array.IndexOf(nums, target);
        //return Search(nums, target, 0, nums.Length - 1);
    }

    private int Search(int[] nums, int target, int begin, int end)
    {
        if (end - begin == 0)
        {
            return nums[begin] == target ? begin : -1;
        }
        if (end - begin == 1)
        {
            if (nums[begin] == target)
                return begin;

            if (nums[end] == target)
                return end;

            return -1;
        }

        int nMiddle = (end + begin) / 2;

        if (nums[nMiddle] == target)
            return nMiddle;

        if (nums[nMiddle] > target)
            return Search(nums, target, begin, nMiddle);
        else
            return Search(nums, target, nMiddle, end);
    }
}