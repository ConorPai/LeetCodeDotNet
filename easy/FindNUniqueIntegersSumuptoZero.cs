//https://leetcode-cn.com/problems/find-n-unique-integers-sum-up-to-zero/

using System.Collections.Generic;

public class FindNUniqueIntegersSumuptoZeroDemo {
    public int[] SumZero(int n) {
        List<int> ret = new List<int>();

        if (n % 2 == 1)
            ret.Add(0);

        int nCount = n / 2;
        for (int i = 1; i <= nCount; i++)
        {
            ret.Add(i);
            ret.Add(-i);
        }

        return ret.ToArray();
    }
}