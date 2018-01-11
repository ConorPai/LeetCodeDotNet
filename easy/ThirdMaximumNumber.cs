//https://leetcode.com/problems/third-maximum-number/description/

public class ThirdMaximumNumberDemo {
    public int ThirdMax(int[] nums) {
        int? nFirst = null;
        int? nSecond = null;
        int? nThird = null;

        foreach (int n in nums)
        {
            if (n.Equals(nFirst) || n.Equals(nSecond) || n.Equals(nThird)) continue;
            if (nFirst == null || n > nFirst) {
                nThird = nSecond;
                nSecond = nFirst;
                nFirst = n;
            } else if (nSecond == null || n > nSecond) {
                nThird = nSecond;
                nSecond = n;
            } else if (nThird == null || n > nThird) {
                nThird = n;
            }
        }

        return nThird == null ? nFirst.Value : nThird.Value;
    }
}