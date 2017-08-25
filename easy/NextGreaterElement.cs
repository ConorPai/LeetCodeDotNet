//https://leetcode.com/problems/next-greater-element-i/description/

using System.Collections.Generic;

public class NextGreaterElementDemo {
    public int[] NextGreaterElement(int[] findNums, int[] nums) {
        
        int[] nResults = new int[findNums.Length];
        
        for(int i = 0; i < findNums.Length;i++)
        {
            int num = findNums[i];
            nResults[i] = -1;

            bool bFind = false;
            for (int j = 0; j < nums.Length; j++)
            {
                if (num == nums[j])
                {
                    bFind = true;
                    continue;
                }

                if (bFind)
                {
                    if (nums[j] > num)
                    {
                        nResults[i] = nums[j];
                        break;
                    }
                }
            }
        }

        return nResults;
    }
}