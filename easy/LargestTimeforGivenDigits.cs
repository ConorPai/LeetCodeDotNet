//https://leetcode-cn.com/problems/largest-time-for-given-digits/

using System;
using System.Collections.Generic;

public class LargestTimeforGivenDigitsDemo {
    public string LargestTimeFromDigits(int[] A) {
        
        SortedSet<int> ssTotal = new SortedSet<int>();
        for (int i = 0; i < A.Length; i++)
        {
            for (int j = 0; j < A.Length; j++)
            {
                if (i == j)
                    continue;

                ssTotal.Add(A[i] * 10 + A[j]);
            }
        }

        IEnumerable<int> result = ssTotal.GetViewBetween(0, 23).Reverse();

        foreach (int r in result)
        {
            int a = r / 10;
            int b = r % 10;

            List<int> values = new List<int>(A);
            values.Remove(a);
            values.Remove(b);

            int leftA = values[0] * 10 + values[1];
            int leftB = values[1] * 10 + values[0];

            if (leftA > 59 && leftB > 59)
                continue;

            if (leftA > 59)
                return string.Format("{0:D2}:{1:D2}", r, leftB);

            if (leftB > 59)
                return string.Format("{0:D2}:{1:D2}", r, leftA);

            int left = Math.Max(leftA, leftB);
            return string.Format("{0:D2}:{1:D2}", r, left);
        }

        return "";
    }

    //最优解
    public string LargestTimeFromDigitsBest(int[] A) {
        
        int max = -1;
        
        for (int i = 0; i < 4; i++)
        for (int j = 0; j < 4; j++) {
            if (j == i) continue;
            for (int k = 0; k < 4; ++k) if (k != i && k != j) {
                int l = 6 - i - j - k;

                int hours = 10 * A[i] + A[j];
                int mins = 10 * A[k] + A[l];
                if (hours < 24 && mins < 60)
                    max = Math.Max(max, hours * 60 + mins);
            }
        }

        if(max == -1) return string.Empty;
        
        return String.Format("{0:D2}:{1:D2}", max/60, max%60);
    }
}