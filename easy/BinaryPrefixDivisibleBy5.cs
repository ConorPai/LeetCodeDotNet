//https://leetcode-cn.com/problems/binary-prefix-divisible-by-5/

using System.Collections.Generic;

public class BinaryPrefixDivisibleBy5Demo {
    public IList<bool> PrefixesDivBy5(int[] A) {
        IList<bool> bRet = new List<bool>();

        int value = 0;
        foreach (int a in A)
        {
            value = (value << 1) + a;
            bRet.Add(value % 5 == 0);
            value %= 5;
        }

        return bRet;
    }
}