//https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/

public class TwoSumIIInputarrayissortedDemo {
    public int[] TwoSum(int[] numbers, int target) {
        int[] nResult = null;

        if (numbers == null || numbers.Length < 2)
            return nResult;
        int left = 0, right = numbers.Length - 1;
        while (left < right)
        {
            int total = numbers[left] + numbers[right];
            if (total == target)
            {
                nResult = new int[2];
                nResult[0] = left + 1;
                nResult[1] = right + 1;
                break;
            } 
            else if (total > target)
                right --;
            else 
                left ++;
        }

        return nResult;
    }
}