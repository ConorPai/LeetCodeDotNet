//https://leetcode.com/problems/single-number/description/

public class SingleNumberDemo {
    public int SingleNumber(int[] nums) {
        
        int nResult = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            nResult ^= nums[i];
        }

        return nResult;
    }
}