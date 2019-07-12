//https://leetcode-cn.com/problems/last-stone-weight/

using System;

public class LastStoneWeightDemo {
    public int LastStoneWeight(int[] stones) {

        if (stones.Length == 0)
            return 0;

        if (stones.Length == 1)
            return stones[0];

        Array.Sort(stones);

        int nLeftCount = stones.Length;
        while (nLeftCount > 1)
        {
            int nleft = stones[nLeftCount - 1] - stones[nLeftCount - 2];
            nLeftCount -= 2;

            bool bIsInsert = false;
            for (int i = 0; i < nLeftCount; i++)
            {
                if (stones[i] > nleft)
                {
                    for (int j = nLeftCount - 1; j >= i; j--)
                        stones[j + 1] = stones[j];
                    
                    stones[i] = nleft;
                    nLeftCount += 1;
                    bIsInsert = true;
                    break;
                }
            }

            if (!bIsInsert)
            {
                stones[nLeftCount] = nleft;
                nLeftCount += 1;
            }
        }
        
        return nLeftCount == 0 ? 0 : stones[0];
    }
}