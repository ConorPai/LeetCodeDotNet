//https://leetcode-cn.com/problems/string-to-integer-atoi/

using System;

public class StringtoIntegerDemo {
    public int MyAtoi(string str) {
        char[] cs = str.Trim(' ').ToCharArray();

        if (cs.Length == 0)
            return 0;

        if (!isNumber(cs[0]) && !isMinus(cs[0]) && !isPlus(cs[0]))
            return 0;
        
        bool bIsMinus = isMinus(cs[0]);
        bool bIsPlus = isPlus(cs[0]);
        int nIndex = 0;
        if (bIsMinus || bIsPlus)
            nIndex = 1;

        int nStep = bIsMinus ? -1 : 1;

        long ret = 0;
        for (int i = nIndex; i < cs.Length; i++)
        {
            if (!isNumber(cs[i]))
                break;

            ret = ret * 10 + (cs[i] - '0') * nStep;

            if (ret > Int32.MaxValue)
                return Int32.MaxValue;

            if (ret < Int32.MinValue)
                return Int32.MinValue;
        }

        return (int)ret;
    }

    private bool isNumber(char c) {
        return (int)c >= 48 && (int)c <= 57;
    }

    private bool isMinus(char c) {
        return c == '-';
    }
    private bool isPlus(char c) {
        return c == '+';
    }
}