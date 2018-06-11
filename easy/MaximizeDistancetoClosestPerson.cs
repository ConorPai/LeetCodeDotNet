//https://leetcode-cn.com/problems/maximize-distance-to-closest-person/description/
using System;

public class MaximizeDistancetoClosestPersonDemo {
    public int MaxDistToClosest(int[] seats) {

        int nMaxDist = 0;
        int nCurZero = 0;
        bool bHavePerson = false;

        for (int i = 0; i < seats.Length; i++)
        {
            int nCurSeat = seats[i];

            if (nCurSeat != 0)
            {
                if (nCurZero != 0)
                {
                    if (bHavePerson)
                    {
                        int nDist = nCurZero % 2 == 0 ? nCurZero / 2 : nCurZero / 2 + 1;
                        nMaxDist = Math.Max(nMaxDist, nDist);
                    }
                    else
                        nMaxDist = Math.Max(nMaxDist, nCurZero);
                    nCurZero = 0;
                }
                bHavePerson = true;
            }
            else
                nCurZero++;
        }

        if (nCurZero != 0)
            nMaxDist = Math.Max(nMaxDist, nCurZero);

        return nMaxDist;
    }
}