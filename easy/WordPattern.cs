//https://leetcode-cn.com/problems/word-pattern/

using System.Collections.Generic;

public class WordPatternDemo {
    public bool WordPattern(string pattern, string str) {
        string[] words = str.Split(' ');
        char[] cs = pattern.ToCharArray();

        if (cs.Length != words.Length)
            return false;

        Dictionary<char, string> p = new Dictionary<char, string>();
        for (int i = 0; i < cs.Length; i++)
        {
            if (!p.ContainsKey(cs[i]))
            {
                foreach (char c in p.Keys)
                {
                    if (p[c] == words[i])
                        return false;
                }
                p[cs[i]] = words[i];
            }
            else
            {
                if (p[cs[i]] != words[i])
                    return false;
            }
        }

        return true;
    }
}