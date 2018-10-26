//https://leetcode-cn.com/problems/contains-duplicate-ii/

using System.Collections.Generic;

public class ContainsDuplicateIIDemo {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int, int> index = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (index.ContainsKey(nums[i]))
            {
                if (i - index[nums[i]] <= k)
                    return true;
            }

            index[nums[i]] = i;
        }

        return false;
    }
}