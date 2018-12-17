//https://leetcode-cn.com/problems/verifying-an-alien-dictionary/

using System;
using System.Collections.Generic;

public class VerifyinganAlienDictionaryDemo {
    public bool IsAlienSorted(string[] words, string order) {
        Dictionary<int, int> orders = new Dictionary<int, int>();
        int index = 1;
        foreach (char c in order.ToCharArray())
            orders[(int)(c - 'a')] = index++;

        int nMaxLength = 0;
        index = 0;
        List<int> jwords = new List<int>();
        foreach (string s in words)
        {
            jwords.Add(index++);
            nMaxLength = Math.Max(s.Length, nMaxLength);
        }

        for (int i = 0; i < nMaxLength; i++)
        {
            int nOri = 0;
            List<int> jwordsNext = new List<int>();
            for (int j = 0; j < jwords.Count; j++)
            {
                char[] cs = words[jwords[j]].ToCharArray();
                if (cs.Length <= i)
                {
                    if (nOri > 0)
                        return false;

                    continue;
                }

                if (orders[(int)(cs[i] - 'a')] < nOri)
                    return false;
                else if (orders[(int)(cs[i] - 'a')] == nOri)
                {
                    if (!jwordsNext.Contains(jwords[j - 1]))
                        jwordsNext.Add(jwords[j - 1]);
                    if (!jwordsNext.Contains(jwords[j]))
                        jwordsNext.Add(jwords[j]);
                }
                else
                    nOri = orders[(int)(cs[i] - 'a')];
            }
            if (jwordsNext.Count == 0)
                return true;
            jwords = jwordsNext;
        }

        return true;
    }
}