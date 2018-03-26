//https://leetcode.com/problems/unique-morse-code-words/description/

using System;
using System.Text;
using System.Collections.Generic;

public class UniqueMorseCodeWordsDemo {

    public int UniqueMorseRepresentations(string[] words) {
        string[] sMorseCodes = new string[]{".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};

        List<string> res = new List<string>();
        foreach(string s in words)
        {
            StringBuilder sb = new StringBuilder();

            foreach(char c in s.ToCharArray())
                sb.Append(sMorseCodes[Convert.ToInt32(c) - 97]);

            string sRet = sb.ToString();
            if (!res.Contains(sRet))
                res.Add(sRet);
        }

        return res.Count;
    }
}