//https://leetcode-cn.com/problems/most-common-word/description/

using System.Collections.Generic;
using System.Text;
using System.Linq;

public class MostCommonWordDemo {
    public string MostCommonWord(string paragraph, string[] banned) {
        
        paragraph = paragraph.ToLower();

        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        StringBuilder sb = new StringBuilder();
        foreach (char c in paragraph.ToCharArray())
        {
            if ((int)c >= 97 && (int)c <= 122)
                sb.Append(c);
            else
            {
                if (sb.Length > 0)
                {
                    string word = sb.ToString();
                    if (wordCount.ContainsKey(word))
                        wordCount[word]++;
                    else
                        wordCount[word] = 1;

                    sb.Clear();
                }
            }
        }

        if (sb.Length > 0)
        {
            string word = sb.ToString();
            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount[word] = 1;
        }

        var dicSort = from objDic in wordCount orderby objDic.Value descending select objDic;
        foreach(KeyValuePair<string, int> kvp in dicSort)
        {
            if (banned.Contains(kvp.Key))
                continue;

            return kvp.Key;  
        }

        return null;
    }
}