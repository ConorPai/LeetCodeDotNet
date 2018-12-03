//https://leetcode-cn.com/problems/shortest-completing-word/

using System;
using System.Collections.Generic;

public class ShortestCompletingWordDemo {
    public string ShortestCompletingWord(string licensePlate, string[] words) {
        
        Dictionary<char, int> licChars = new Dictionary<char, int>();
        char[] cs = licensePlate.ToLower().ToCharArray();
        foreach (char c in cs)
        {
            if (!IsLetter(c))
                continue;
            if (licChars.ContainsKey(c))
                licChars[c]++;
            else
                licChars[c] = 1;
        }

        int nMinLength = Int32.MaxValue;
        string sWord = "";

        foreach (string s in words)
        {
            Dictionary<char, int> lcClone = new Dictionary<char, int>(licChars);
            char[] ws = s.ToLower().ToCharArray();

            foreach (char c in ws)
            {
                if (lcClone.ContainsKey(c))
                {
                    lcClone[c]--;
                    if (lcClone[c] == 0)
                    {
                        lcClone.Remove(c);
                        if (lcClone.Count == 0)
                        {
                            if (ws.Length < nMinLength)
                            {
                                nMinLength = ws.Length;
                                sWord = s;
                            }
                        }
                    }
                }
            }
        }

        return sWord;
    }

    private bool IsLetter(char c)
    {
        int value = (int)c;
        return value >= 97 && value <= 122;
    }
}