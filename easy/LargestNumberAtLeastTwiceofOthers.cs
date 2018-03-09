//https://leetcode.com/problems/largest-number-at-least-twice-of-others/description/

using System.Collections.Generic;

public class LargestNumberAtLeastTwiceofOthersDemo {
    public int DominantIndex(int[] nums) {
        if (nums == null || nums.Length == 0)
            return -1;

        if (nums.Length == 1)
            return 0;

        List<int> listNums = new List<int>(nums);
        listNums.Sort();
        if (listNums[listNums.Count - 1] < listNums[listNums.Count - 2] * 2)
            return -1;

        for (int i = 0; i < nums.Length; i++)
            if (nums[i] == listNums[listNums.Count - 1])
                return i;

        return -1;
    }
}