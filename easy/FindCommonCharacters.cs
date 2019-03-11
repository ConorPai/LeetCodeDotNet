//https://leetcode-cn.com/problems/find-common-characters/

using System;
using System.Collections.Generic;

public class FindCommonCharactersDemo {
    public IList<string> CommonChars(string[] A) {
        if (A.Length == 0)
            return null;
        Dictionary<int, int> contains = new Dictionary<int, int>();
        List<int> containsKeys = new List<int>();

        foreach (char c in A[0].ToCharArray())
        {
            if (contains.ContainsKey(c))
                contains[c]++;
            else
            {
                contains[c] = 1;
                containsKeys.Add(c);
            }
        }

        for (int i = 1; i < A.Length; i++)
        {
            Dictionary<int, int> containsTemp = new Dictionary<int, int>();
            foreach (char c in A[i].ToCharArray())
            {
                if (containsTemp.ContainsKey(c))
                    containsTemp[c]++;
                else
                    containsTemp[c] = 1;
            }

            for (int j = 0; j < containsKeys.Count; j++)
            {
                int c = containsKeys[j];

                if (contains[c] == 0)
                    continue;
                
                if (containsTemp.ContainsKey(c))
                    contains[c] = Math.Min(contains[c], containsTemp[c]);
                else
                    contains[c] = 0;
            }
        }

        IList<string> ret = new List<string>();
        foreach (char c in contains.Keys)
        {
            if (contains[c] != 0)
            {
                for (int i = 0; i < contains[c]; i++)
                    ret.Add(c.ToString());
            }
        }

        return ret;
    }
}