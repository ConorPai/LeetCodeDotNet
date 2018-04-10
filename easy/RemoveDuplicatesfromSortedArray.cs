//https://leetcode-cn.com/problems/remove-duplicates-from-sorted-array/description/

public class RemoveDuplicatesfromSortedArrayDemo {
    public int RemoveDuplicates(int[] nums) {

        if (nums.Length == 0)
            return 0;
        
        int nLastNum = nums[0];
        int nNewLength = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nLastNum)
                continue;

            if (nNewLength != i)
                nums[nNewLength] = nums[i];
            nLastNum = nums[i];
            nNewLength++;
        }

        return nNewLength;
    }
}