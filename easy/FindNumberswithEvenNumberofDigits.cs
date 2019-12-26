//https://leetcode-cn.com/problems/find-numbers-with-even-number-of-digits/

public class FindNumberswithEvenNumberofDigitsDemo {
    public int FindNumbers(int[] nums) {
        int nCount = 0;
        foreach (int n in nums)
            if (n.ToString().Length % 2 == 0)
                nCount++;
        return nCount;
    }
}