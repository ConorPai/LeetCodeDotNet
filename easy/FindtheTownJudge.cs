//https://leetcode-cn.com/problems/find-the-town-judge/

using System.Collections.Generic;

public class FindtheTownJudgeDemo {
    public int FindJudge(int N, int[][] trust) {
        if (N == 1 && trust.Length == 0)
            return 1;
        Dictionary<int, int> trustCount = new Dictionary<int, int>();
        Dictionary<int, int> betrustCount = new Dictionary<int, int>();

        for (int i = 0; i < trust.Length; i++)
        {
            if (!trustCount.ContainsKey(trust[i][0]))
                trustCount[trust[i][0]] = 0;

            trustCount[trust[i][0]]++;

            if (!betrustCount.ContainsKey(trust[i][1]))
                betrustCount[trust[i][1]] = 0;

            betrustCount[trust[i][1]]++;
        }

        foreach(int key in betrustCount.Keys)
        {
            if (betrustCount[key] == N - 1 && !trustCount.ContainsKey(key))
                return key;
        }

        return -1;
    }
}