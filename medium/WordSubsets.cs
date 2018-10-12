//https://leetcode-cn.com/problems/word-subsets/

using System;
using System.Collections.Generic;

public class WordSubsetsDemo {
    public IList<string> WordSubsets(string[] A, string[] B) {
        IList<string> ret = new List<string>();
        Dictionary<char, int> BWords = new Dictionary<char, int>();
        foreach (string b in B)
        {
            char[] cs = b.ToCharArray();
            Dictionary<char, int> bWords = new Dictionary<char, int>();
            foreach (char c in cs)
            {
                if (bWords.ContainsKey(c))
                    bWords[c]++;
                else
                    bWords[c] = 1;
            }

            foreach (char c in bWords.Keys)
            {
                if (BWords.ContainsKey(c))
                    BWords[c] = Math.Max(BWords[c], bWords[c]);
                else
                    BWords[c] = bWords[c];
            }
        }

        foreach (string a in A)
        {
            char[] cs = a.ToCharArray();
            Dictionary<char, int> aWords = new Dictionary<char, int>();
            foreach (char c in cs)
            {
                if (aWords.ContainsKey(c))
                    aWords[c]++;
                else
                    aWords[c] = 1;
            }
                
            bool bExist = true;
            foreach (char c in BWords.Keys)
            {
                if (!aWords.ContainsKey(c) || aWords[c] < BWords[c])
                {
                    bExist = false;
                    break;
                }
            }

            if (bExist)
                ret.Add(a);
        }

        return ret;
    }
}