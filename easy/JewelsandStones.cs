//https://leetcode.com/problems/jewels-and-stones/description/

using System.Collections.Generic;

public class JewelsandStonesDemo {
    public int NumJewelsInStones(string J, string S) {
        Dictionary<char, int> stoneCount = new Dictionary<char, int>();

        foreach (char c in S.ToCharArray())
        {
            if (stoneCount.ContainsKey(c))
                stoneCount[c]++;
            else
                stoneCount[c] = 1;
        }

        int nTotalCount = 0;
        foreach (char c in J.ToCharArray())
        {
            if (stoneCount.ContainsKey(c))
                nTotalCount += stoneCount[c];
        }

        return nTotalCount;
    }
}