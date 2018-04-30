//https://leetcode-cn.com/problems/factorial-trailing-zeroes/description/

public class FactorialTrailingZeroesDemo {
    public int TrailingZeroes(int n) {
        if (n < 5)
            return 0;

        int nTotalCount = 0;
        while (n != 0)
        {
            nTotalCount += n / 5;
            n /= 5;
        }

        return nTotalCount;
    }
}