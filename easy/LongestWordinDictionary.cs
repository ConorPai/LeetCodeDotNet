//https://leetcode.com/problems/longest-word-in-dictionary/description/

using System.Collections.Generic;

public class LongestWordinDictionaryDemo {
    public string LongestWord(string[] words) {
        List<string> listWords = new List<string>(words);
        listWords.Sort((x, y) => 
        {
            if (x.Length == y.Length)
                return x.CompareTo(y);

            return x.Length > y.Length ? 1 : -1;
        });

        List<string> listResult = new List<string>();
        foreach (string word in listWords)
        {
            if (word.Length == 1 || listResult.Contains(word.Substring(0, word.Length - 1)))
                listResult.Add(word);
        }

        listResult.Sort((x, y) => 
        {
            if (x.Length == y.Length)
                return x.CompareTo(y);

            return x.Length < y.Length ? 1 : -1;
        });

        return listResult[0];
    }
}