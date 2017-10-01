//https://leetcode.com/problems/contains-duplicate/description/

using System.Collections.Generic;

public class ContainsDuplicateDemo {
    public bool ContainsDuplicate(int[] nums) {

        HashSet<int> repeat = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!repeat.Add(nums[i]))
                return true;
        }

        return false;
    }
}