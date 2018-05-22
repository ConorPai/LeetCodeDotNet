//https://leetcode-cn.com/problems/isomorphic-strings/description/

using System.Collections.Generic;

public class IsomorphicStringsDemo {
    public bool IsIsomorphic(string s, string t) {
        if (s.Length != t.Length)
            return false;

        char[] csS = s.ToCharArray();
        char[] csT = t.ToCharArray();

        List<char> listS = new List<char>();
        List<char> listT = new List<char>();
        for (int i = 0; i < csS.Length; i++)
        {
            if (listS.Contains(csS[i]))
            {
                int index = listS.FindIndex(c => c == csS[i]);
                if (listT[index] != csT[i])
                    return false;
            }
            else
            {
                listS.Add(csS[i]);
                if (listT.Contains(csT[i]))
                    return false;
                listT.Add(csT[i]);
            }
        }

        return true;
    }
}