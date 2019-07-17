//https://leetcode-cn.com/problems/relative-sort-array/

using System;
using System.Collections.Generic;

public class RelativeSortArrayDemo {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        List<int> others = new List<int>();
        Dictionary<int,int> exists = new Dictionary<int, int>();
        SortedSet<int> ss = new SortedSet<int>(arr2);

        foreach (int item in arr1)
        {
            if (ss.Contains(item))
            {
                if (exists.ContainsKey(item))
                    exists[item]++;
                else
                    exists[item] = 1;
            }
            else
            {
                others.Add(item);
            }
        }

        List<int> result = new List<int>();
        foreach (int item in arr2)
        {
            for (int i = 0; i < exists[item]; i++)
                result.Add(item);
        }

        others.Sort();
        result.AddRange(others);
        return result.ToArray();
    }
}