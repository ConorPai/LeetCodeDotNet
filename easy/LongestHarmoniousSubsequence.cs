//https://leetcode.com/problems/longest-harmonious-subsequence/description/
using System.Linq;
using System.Collections.Generic;

public class LongestHarmoniousSubsequenceDemo {
    public int FindLHS(int[] nums) {
        
        Dictionary<int, int> dictNums = new Dictionary<int, int>();
        foreach (int n in nums)
        {
            if (dictNums.ContainsKey(n))
                dictNums[n]++;
            else
                dictNums[n] = 1;
        }

        int nResult = 0;
        foreach (int n in dictNums.Keys)
        {
            if (dictNums.ContainsKey(n + 1))
                nResult = nResult > dictNums[n] + dictNums[n + 1] ? nResult : dictNums[n] + dictNums[n + 1];
        }

        return nResult;
    }
}