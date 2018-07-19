//https://leetcode-cn.com/problems/first-unique-character-in-a-string/description/

using System.Collections.Generic;

public class FirstUniqueCharacterinaStringDemo {
    public int FirstUniqChar(string s) {
        Dictionary<char, int> uniChar = new Dictionary<char, int>();
        
        int nIndex = 0;
        foreach (char c in s.ToCharArray())
        {
            if (uniChar.ContainsKey(c))
                uniChar[c] = -1;
            else
                uniChar[c] = nIndex;

            nIndex++;
        }

        foreach (char c in uniChar.Keys)
        {
            if (uniChar[c] == -1)
                continue;
        
            return uniChar[c];
        }

        return -1;
    }
}