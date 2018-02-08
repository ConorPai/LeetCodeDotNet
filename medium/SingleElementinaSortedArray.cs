//https://leetcode.com/problems/single-element-in-a-sorted-array/description/

public class SingleElementinaSortedArrayDemo {
    public int SingleNonDuplicate(int[] nums) {
        
        if (nums == null || nums.Length == 0)
            return -1;
        int nRet = nums[0];

        for (int i = 1; i < nums.Length; i++)
            nRet ^= nums[i];

        return nRet;
    }
}