//https://leetcode.com/problems/remove-element/description/

public class RemoveElementDemo {
    public int RemoveElement(int[] nums, int val) {
        
        int nCurIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                if (i != nCurIndex)
                {
                    nums[nCurIndex] = nums[i];
                    nums[i] = 0;
                }
                nCurIndex++;
            }
        }

        return nCurIndex;
    }
}