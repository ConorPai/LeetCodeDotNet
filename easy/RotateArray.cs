//https://leetcode.com/problems/rotate-array/description/

using System.Collections.Generic;

public class RotateArrayDemo {
    public void Rotate1(int[] nums, int k) {
        int nLen = nums.Length;
        while (k > nLen)
            k -= nLen;
        
        int[] temp = new int[k];

        for (int i = 0; i < k; i++)
            temp[i] = nums[nLen - k + i];
        
        for (int i = nLen - 1; i >= k; i--)
            nums[i] = nums[i - k];
        
        for (int i = 0; i < k; i++)
            nums[i] = temp[i];
    }
}