//https://leetcode.com/problems/maximum-product-of-three-numbers/description/

using System.Collections.Generic;

public class MaximumProductofThreeNumbersDemo {
    public int MaximumProduct(int[] nums) {
        List<int> listNums = new List<int>(nums);
        listNums.Sort();

        int nCount = listNums.Count;
        int nResult1 = listNums[nCount - 1] * listNums[nCount - 2] * listNums[nCount - 3];

        //如果前两个数是负数，和最后一个数相乘也有可能成为最大值
        int nResult2 = listNums[0] * listNums[1] * listNums[nCount - 1];

        return nResult1 > nResult2 ? nResult1 : nResult2;
    }
}