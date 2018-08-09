//https://leetcode-cn.com/problems/relative-ranks/description/

using System.Linq;
using System.Collections.Generic;

public class RelativeRanksDemo {
    public string[] FindRelativeRanks(int[] nums) {
        Dictionary<int, int> scores = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            scores[nums[i]] = i;
        }

        string[] ret = new string[nums.Length];
        var dicSort = from objDic in scores orderby objDic.Key descending select objDic;
        int nIndex = 1;
        foreach(KeyValuePair<int, int> kvp in dicSort)
        {
            if (nIndex == 1)
                ret[kvp.Value] = "Gold Medal";
            else if (nIndex == 2)
                ret[kvp.Value] = "Silver Medal";
            else if (nIndex == 3)
                ret[kvp.Value] = "Bronze Medal";
            else
                ret[kvp.Value] = nIndex.ToString();

            nIndex++;
        }

        return ret;
    }
}