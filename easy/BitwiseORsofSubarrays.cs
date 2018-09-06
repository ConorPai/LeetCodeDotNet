//https://leetcode-cn.com/problems/bitwise-ors-of-subarrays/description/

using System.Collections.Generic;

public class BitwiseORsofSubarraysDemo {
    public int SubarrayBitwiseORs(int[] A) {
        HashSet<int> ret = new HashSet<int>();
        HashSet<int> pre = new HashSet<int>();

        foreach (int a in A)
        {
            HashSet<int> cur = new HashSet<int>();
            cur.Add(a);

            foreach (int i in pre)
                cur.Add(a | i);

            pre = cur;
            ret.UnionWith(cur);
        }

        return ret.Count;
    }
}