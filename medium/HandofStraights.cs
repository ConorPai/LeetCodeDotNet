//https://leetcode-cn.com/problems/hand-of-straights/description/

using System.Collections.Generic;

public class HandofStraightsDemo {
    public bool IsNStraightHand(int[] hand, int W) {
        if (hand.Length % W != 0)
            return false;

        Dictionary<int, int> handDict = new Dictionary<int, int>();
        SortedSet<int> handSet = new SortedSet<int>();

        foreach (int i in hand)
        {
            if (handDict.ContainsKey(i))
                handDict[i]++;
            else
            {
                handDict[i] = 1;
                handSet.Add(i);
            }
        }

        foreach (int i in handSet)
        {
            if (handDict[i] == 0)
                continue;

            for (int j = 1; j < W; j++)
            {
                if (!handDict.ContainsKey(i + j))
                    return false;

                if (handDict[i + j] < handDict[i])
                    return false;

                handDict[i + j] -= handDict[i];
            }
            
            handDict[i] -= handDict[i];
        }

        return true;
    }
}