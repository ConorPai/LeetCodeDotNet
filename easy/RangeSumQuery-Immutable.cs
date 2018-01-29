//https://leetcode.com/problems/range-sum-query-immutable/description/

public class NumArray {

    private int[] m_nNums = null;
    public NumArray(int[] nums) {
        for (int i = 1; i < nums.Length; i++)
            nums[i] += nums[i - 1];
        m_nNums = nums;
    }
    
    public int SumRange(int i, int j) {
        if (i == 0)
            return m_nNums[j];

        return m_nNums[j] - m_nNums[i - 1];
    }
}