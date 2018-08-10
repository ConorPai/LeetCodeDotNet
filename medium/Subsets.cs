//https://leetcode-cn.com/problems/subsets/description/

using System.Collections.Generic;

public class SubsetsDemo {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> ret = new List<IList<int>>();

        foreach (int n in nums) {
            int nCount = ret.Count;
            for (int i = 0; i < nCount; i++) {
                IList<int> list = new List<int>(ret[i]);
                list.Add(n);
                ret.Add(list);
            }
            ret.Add(new List<int>(){n});
        }
        ret.Add(new List<int>());

        return ret;
    }
}