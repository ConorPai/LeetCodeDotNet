//https://leetcode-cn.com/problems/two-city-scheduling/comments/

using System.Linq;
using System.Collections.Generic;

public class TwoCitySchedulingDemo {
    public int TwoCitySchedCost(int[][] costs) {
        
        Dictionary<int, List<int>> sorts = new Dictionary<int, List<int>>();
        for (int i = 0; i < costs.Length; i++)
        {
            int nValue = costs[i][0] - costs[i][1];
            if (sorts.ContainsKey(nValue))
                sorts[nValue].Add(i);
            else
                sorts[nValue] = new List<int>(){i};
        }

        int nRetValue = 0;
        int nCount = costs.Length / 2;
        var dicSort = from objDic in sorts orderby objDic.Key select objDic;
        foreach(KeyValuePair<int, List<int>> kvp in dicSort)
        {
            for (int i = 0; i < kvp.Value.Count; i++)
            {
                nRetValue += nCount > 0 ? costs[kvp.Value[i]][0] : costs[kvp.Value[i]][1];
                nCount--;
            }
        }

        return nRetValue;
    }
}