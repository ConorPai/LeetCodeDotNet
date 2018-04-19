//https://leetcode-cn.com/problems/pascals-triangle/description/

using System.Collections.Generic;

public class PascalsTriangleDemo {
    public IList<IList<int>> Generate(int numRows) {
        
        IList<IList<int>> ret = new List<IList<int>>();
        if (numRows == 0)
            return ret;
        ret.Add(new List<int>(){1});
        for (int i = 1; i < numRows; i++)
        {
            IList<int> cur = new List<int>();
            cur.Add(1);
            for (int j = 0; j < ret[i - 1].Count - 1; j++)
                cur.Add(ret[i - 1][j] + ret[i - 1][j + 1]);
            cur.Add(1);
            ret.Add(cur);
        }

        return ret;
    }
}