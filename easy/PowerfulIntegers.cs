//https://leetcode-cn.com/problems/powerful-integers/

using System;
using System.Collections.Generic;

public class PowerfulIntegersDemo {
    public IList<int> PowerfulIntegers(int x, int y, int bound) {
        SortedSet<int> sortRet = new SortedSet<int>();

        for (int m = 1; m < bound; m *= x)
        {
            for (int n = 1; m + n <= bound; n *= y)
            {
                sortRet.Add(m + n);
                if (y == 1)
                    break;
            }

            if (x == 1)
                break;
        }

        return new List<int>(sortRet);
    }
}