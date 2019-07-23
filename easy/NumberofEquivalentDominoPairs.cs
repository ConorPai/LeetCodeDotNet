//https://leetcode-cn.com/problems/number-of-equivalent-domino-pairs/

using System.Collections.Generic;

public class NumberofEquivalentDominoPairsDemo {
    public int NumEquivDominoPairs(int[][] dominoes) {
        int nRet = 0;
        Dictionary<int, int> times = new Dictionary<int, int>();
        for (int i = 0; i < dominoes.Length; i++)
        {
            int nKey = 0;
            if (dominoes[i][0] > dominoes[i][1])
                nKey = dominoes[i][0] * 10 + dominoes[i][1];
            else
                nKey = dominoes[i][1] * 10 + dominoes[i][0];

            if (times.ContainsKey(nKey))
            {
                nRet += times[nKey];
                times[nKey]++;
            }
            else
            {
                times[nKey] = 1;
            }
        }

        return nRet;
    }
}