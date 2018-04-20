//https://leetcode-cn.com/problems/pascals-triangle-ii/description/

using System.Collections.Generic;

public class PascalsTriangleIIDemo {
    public IList<int> GetRow(int rowIndex) {
        IList<int> ret = new List<int>();

        ret.Add(1);
        for (int i = 1; i <= rowIndex; i++)
            ret.Add((int)((long)ret[ret.Count - 1] * (long)(rowIndex - i + 1) / i));
        
        return ret;
    }
}