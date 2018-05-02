//https://leetcode-cn.com/problems/house-robber/description/

using System;

public class HouseRobberDemo {
    public int Rob(int[] nums) {
        
        if (nums.Length==0)
            return 0;
        if (nums.Length==1)
            return nums[0];
        nums[1] = Math.Max(nums[0], nums[1]);
        
        for (int i = 2; i < nums.Length; i++)
            nums[i] = nums[i] + nums[i - 2] > nums[i - 1] ? nums[i] + nums[i-2] : nums[i - 1];
        
        return nums[nums.Length - 1];
    }
}