//https://leetcode-cn.com/problems/heaters/description/

using System;
using System.Collections.Generic;

public class HeatersDemo {
    public int FindRadius(int[] houses, int[] heaters) {
        SortedSet<int> sortedHouses = new SortedSet<int>(houses);
        List<int> listHeaters = new List<int>(heaters);
        listHeaters.Sort();

        int nMaxRadius = 0;
        for (int i = 0; i <= listHeaters.Count; i++)
        {
            int nLastHeaters = i == 0 ? Int32.MinValue : listHeaters[i - 1];
            int nCurHeaters = i == heaters.Length ? Int32.MaxValue : listHeaters[i];

            if (nLastHeaters == nCurHeaters)
                continue;
            
            SortedSet<int> hs = sortedHouses.GetViewBetween(nLastHeaters, nCurHeaters);
            foreach (int element in hs)
            {
                if (element == nLastHeaters || element == nCurHeaters)
                    continue;
                int nCurLeft = nLastHeaters == Int32.MinValue ? Int32.MaxValue : element - nLastHeaters;
                int nCurRight = nCurHeaters == Int32.MaxValue ? Int32.MaxValue : nCurHeaters - element;
                nMaxRadius = Math.Max(nMaxRadius, Math.Min(nCurLeft, nCurRight));
            }
        }

        return nMaxRadius;
    }
}