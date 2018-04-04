//https://leetcode-cn.com/problems/set-mismatch/description/

using System.Collections.Generic;

public class SetMismatchDemo {
    public int[] FindErrorNums(int[] nums) {
        int[] count = new int[nums.Length];
        int[] ret = new int[2]{-1, 0};
        for(int i = 0; i < nums.Length; i++)
        {
            ret[1] ^= (i + 1) ^ nums[i];

            if (ret[0] == -1)
            {
                count[nums[i] - 1]++;
                if (count[nums[i] - 1] == 2)
                    ret[0] = nums[i];
            }
        }

        ret[1] ^= ret[0];
        return ret;
    }
}