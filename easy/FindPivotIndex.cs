//https://leetcode.com/problems/find-pivot-index/description/

public class FindPivotIndexDemo {
    public int PivotIndex(int[] nums) {
        
        int sum = 0, left = 0;
        for (int i = 0; i < nums.Length; i++) sum += nums[i];
        
        for (int i = 0; i < nums.Length; i++) {
            if (i != 0) left += nums[i - 1];
            if (sum - left - nums[i] == left) return i;
        }
        
        return -1;
    }
}