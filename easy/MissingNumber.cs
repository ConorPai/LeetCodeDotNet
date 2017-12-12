//https://leetcode.com/problems/missing-number/description/

public class MissingNumberDemo {
    public int MissingNumber(int[] nums) {
        
        int nTotal = nums.Length * (nums.Length + 1) / 2;
        foreach (int num in nums)
            nTotal -= num;

        return nTotal;
    }
}