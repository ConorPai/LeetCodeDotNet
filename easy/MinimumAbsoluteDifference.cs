//https://leetcode-cn.com/problems/minimum-absolute-difference/

using System;
using System.Collections.Generic;

public class MinimumAbsoluteDifferenceDemo {
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        Array.Sort(arr);

        int nMinDif = int.MaxValue;

        IList<IList<int>> ret = new List<IList<int>>();
        for (int i = 1; i < arr.Length; i++)
        {
            int dif = arr[i] - arr[i - 1];

            if (dif > nMinDif)
                continue;
            if (dif < nMinDif)
                ret.Clear();
            ret.Add(new List<int>(){arr[i - 1], arr[i]});
            nMinDif = dif;
        }

        return ret;
    }
}