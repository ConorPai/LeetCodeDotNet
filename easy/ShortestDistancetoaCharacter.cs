//https://leetcode-cn.com/problems/shortest-distance-to-a-character/description/

using System;
using System.Collections.Generic;

public class ShortestDistancetoaCharacterDemo {
    public int[] ShortestToChar(string S, char C) {
        List<int> zeroIndex = new List<int>();
        char[] cs = S.ToCharArray();

        int[] nRet = new int[cs.Length];
        for (int i = 0; i < cs.Length; i++)
        {
            if (cs[i] == C)
            {
                zeroIndex.Add(i);
                nRet[i] = 0;
            }
        }

        for (int i = 0; i < cs.Length; i++)
        {
            if (i < zeroIndex[0])
                nRet[i] = zeroIndex[0] - i;
            else if (i > zeroIndex[zeroIndex.Count - 1])
                nRet[i] = i - zeroIndex[zeroIndex.Count - 1];
            else
            {
                int nSmallIndex = -1;
                for (int j = 0; j < zeroIndex.Count - 1; j++)
                {
                    if (zeroIndex[j] < i && zeroIndex[j + 1] > i)
                    {
                        nSmallIndex = j;
                        break;
                    }
                    else if (zeroIndex[j] == i)
                        break;
                }

                if (nSmallIndex != -1)
                    nRet[i] = Math.Min(i - zeroIndex[nSmallIndex], zeroIndex[nSmallIndex + 1] - i);
            }
        }

        return nRet;
    }
}