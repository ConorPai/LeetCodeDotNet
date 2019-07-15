//https://leetcode-cn.com/problems/occurrences-after-bigram/

using System.Collections.Generic;

public class Solution {
    public string[] FindOcurrences(string text, string first, string second) {
        string[] texts = text.Split(" ");

        int nState = 0;
        List<string> rst = new List<string>();
        foreach (string t in texts)
        {
            if (nState == 2)
            {
                rst.Add(t);
                nState = 0;
            }
            if (t.CompareTo(first) == 0)
            {
                nState = 1;
                continue;
            }
            if (nState == 1 && t.CompareTo(second) == 0)
            {
                nState = 2;
                continue;
            }

            nState = 0;
        }

        return rst.ToArray();
    }
}