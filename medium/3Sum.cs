//https://leetcode-cn.com/problems/3sum/solution/three-sum-giftu-jie-by-githber/

using System;
using System.Collections.Generic;

public class ThreeSumDemo {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);

        IList<IList<int>> ret = new List<IList<int>>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
                break;

            //去重
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int l = i + 1;
            int r = nums.Length - 1;

            while (l < r)
            {
                int nSum = nums[i] + nums[l] + nums[r];

                if (nSum == 0)
                {
                    ret.Add(new List<int>(){nums[i], nums[l], nums[r]});
                    //去重
                    while (l < r && nums[r] == nums[r - 1]) r--;
                    while (l < r && nums[l] == nums[l + 1]) l++;
                    r--;
                    l++;
                }
                else if (nSum > 0)
                {
                    //去重
                    while (l < r && nums[r] == nums[r - 1]) r--;
                    r--;
                }
                else
                {
                    //去重
                    while (l < r && nums[l] == nums[l + 1]) l++;
                    l++;
                }
            }
        }
        return ret;
    }
}