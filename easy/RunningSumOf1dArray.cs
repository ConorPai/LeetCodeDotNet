public class RunningSumOf1dArray {
    public int[] RunningSum(int[] nums) {
        int[] ret = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++) {
            if (i == 0)
                ret[i] = nums[i];
            else
                ret[i] = ret[i - 1] + nums[i];
        }

        return ret;
    }
}