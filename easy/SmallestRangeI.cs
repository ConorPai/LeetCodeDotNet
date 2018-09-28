//https://leetcode-cn.com/problems/smallest-range-i/

using System.Linq;

public class SmallestRangeIDemo {
    public int SmallestRangeI(int[] A, int K) {
        //最小差值=(数组最大值-K) - (数组最小值+K)
        int minVal = A.Max() - A.Min() - 2 * K;
        return minVal < 0 ? 0 : minVal;
    }
}