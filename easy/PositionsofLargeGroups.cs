//https://leetcode-cn.com/problems/positions-of-large-groups/description/

using System.Collections.Generic;

public class PositionsofLargeGroupsDemo {
    public IList<IList<int>> LargeGroupPositions(string S) {
        
        IList<IList<int>> ret = new List<IList<int>>();

        if (string.IsNullOrEmpty(S))
            return ret;
        
        char[] cs = S.ToCharArray();
        char cur = cs[0];
        int count = 1;
        int lastIndex = 0;

        for (int i = 1; i < cs.Length; i++)
        {
            if (cs[i] == cur)
                count++;
            else
            {
                if (count >= 3)
                    ret.Add(new List<int>(){lastIndex, i - 1});

                cur = cs[i];
                count = 1;
                lastIndex = i;
            }
        }

        if (count >= 3)
            ret.Add(new List<int>(){lastIndex, cs.Length - 1});

        return ret;
    }
}