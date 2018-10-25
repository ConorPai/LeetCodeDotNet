//https://leetcode-cn.com/problems/non-decreasing-array/

public class NondecreasingArrayDemo {
    public bool CheckPossibility(int[] nums) {
        if (nums == null || nums.Length == 0)
            return false;

        bool bIsUsed = false;
        for(int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] > nums[i])
            {
                if (bIsUsed)
                    return false;

                bIsUsed = true;

                if (i > 1)
                {
                    if (nums[i - 2] < nums[i])
                        nums[i - 1] = nums[i];
                    else
                        nums[i] = nums[i - 1];
                }
            }

        }

        return true;
    }
}