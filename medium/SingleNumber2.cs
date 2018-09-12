//https://leetcode-cn.com/problems/single-number-ii/description/

using System;

public class SingleNumber2Demo {
    public int SingleNumber(int[] nums) {
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i += 3)
        {
            if (nums[i] != nums[i + 1] || nums[i] != nums[i + 2])
                return nums[i];
        }

        return nums[nums.Length-1];
    }
}