//https://leetcode.com/problems/valid-anagram/description/

using System.Collections.Generic;

public class ValidAnagramDemo {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length)
            return false;
        
        Dictionary<char, int> sChars = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (sChars.ContainsKey(c))
            {
                sChars[c]++;
            }
            else
            {
                sChars[c] = 1;
            }
        }

        bool bRet = true;
        foreach (char c in t)
        {
            if (!sChars.ContainsKey(c))
            {
                bRet = false;
                break;
            }

            sChars[c]--;

            if (sChars[c] == 0)
                sChars.Remove(c);
        }

        if (!bRet)
            return false;

        return sChars.Count == 0;
    }
}