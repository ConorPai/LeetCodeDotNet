//https://leetcode-cn.com/problems/buddy-strings/description/

using System.Collections.Generic;

public class BuddyStringsDemo {
    public bool BuddyStrings(string A, string B) {
        
        if (A.Length != B.Length)
            return false;

        if (A.CompareTo(B) == 0)
        {
            List<char> ch = new List<char>();
            foreach (char c in A.ToCharArray())
            {
                if (ch.Contains(c))
                    return true;

                ch.Add(c);
            }
        }

        List<char> cs = new List<char>();
        char[] cA = A.ToCharArray();
        char[] cB = B.ToCharArray();

        for (int i = 0; i < cA.Length; i++)
        {
            if (cA[i] != cB[i])
            {
                if (cs.Count == 0)
                {
                    cs.Add(cA[i]);
                    cs.Add(cB[i]);
                }
                else if (cs.Count == 2)
                {
                    if (cA[i] != cs[1] || cB[i] != cs[0])
                        return false;

                    cs.Add(cA[i]);
                    cs.Add(cB[i]);
                }
                else
                    return false;
            }
        }

        return cs.Count == 4;
    }
}