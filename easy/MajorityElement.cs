//https://leetcode-cn.com/problems/majority-element/description/

using System.Collections.Generic;

public class MajorityElementDemo {
    public int MajorityElement(int[] nums) {
        if (nums.Length == 1)
            return nums[0];
        
        int nCount = nums.Length / 2;
        Dictionary<int, int> numsCount = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (numsCount.ContainsKey(nums[i]))
            {
                numsCount[nums[i]]++;
                if (numsCount[nums[i]] > nCount)
                    return nums[i];
            }
            else
                numsCount[nums[i]] = 1;
        }

        return -1;
    }
}