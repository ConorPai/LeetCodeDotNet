//https://leetcode.com/problems/array-partition-i/description/

using System.Collections.Generic;

public class ArrayPartitionIDemo {
    public int ArrayPairSum(int[] nums) {
        List<int> list = new List<int>(nums);
        list.Sort();

        int nTemp = 0;
        int nResult = 0;
        foreach (int num in list)
        {
            if (nTemp++ % 2 != 0)
                continue;

            nResult += num;
        }

        return nResult;
    }
}