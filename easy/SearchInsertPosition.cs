//https://leetcode.com/problems/search-insert-position/description/

public class SearchInsertPositionDemo {
    public int SearchInsert(int[] nums, int target) {
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
                return i;

            if (nums[i] > target)
                return i - 1 < 0 ? 0 : i;
        }

        return nums.Length;
    }
}