//https://leetcode-cn.com/problems/shifting-letters/description/

using System;
using System.Text;

public class ShiftingLettersDemo {
    public string ShiftingLetters(string S, int[] shifts) {

        StringBuilder sbResult = new StringBuilder();
        long nTotalShifting = 0;
        char[] cs = S.ToCharArray();
        for (int i = cs.Length - 1; i >= 0; i--)
        {
            if (i >= shifts.Length)
            {
                sbResult.Append(cs[i]);
                continue;
            }
            
            nTotalShifting += shifts[i];
            sbResult.Append(ShiftingChar(cs[i], nTotalShifting));
        }

        char[] cRet = sbResult.ToString().ToCharArray();
        Array.Reverse(cRet);
        return new string(cRet);
    }

    private char ShiftingChar(char c, long i)
    {
        long nNewChar = (long)c + i % 26;
        if (nNewChar > 122)
            nNewChar = nNewChar - 122 + 96;

        return (char)nNewChar;
    }
}