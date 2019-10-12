//https://leetcode-cn.com/problems/maximum-number-of-balloons/

using System.Collections.Generic;

public class MaximumNumberofBalloonsDemo {
    public int MaxNumberOfBalloons(string text) {
        Dictionary<int, int> charTimes = new Dictionary<int, int>();

        charTimes[(int)'b'] = 0;
        charTimes[(int)'a'] = 0;
        charTimes[(int)'l'] = 0;
        charTimes[(int)'o'] = 0;
        charTimes[(int)'n'] = 0;

        foreach (char c in text.ToCharArray())
        {
            if (charTimes.ContainsKey((int)c))
                charTimes[(int)c]++;
        }

        int nMin = System.Int32.MaxValue;
        foreach (int val in charTimes.Keys)
        {
            int nValue = charTimes[val];
            if (val == (int)'l' || val == (int)'o')
                nValue /= 2;

            nMin = nMin < nValue ? nMin : nValue;
        }

        return nMin;
    }
}