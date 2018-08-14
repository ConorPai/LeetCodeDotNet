//https://leetcode-cn.com/problems/uncommon-words-from-two-sentences/description/

using System.Collections.Generic;

public class UncommonWordsfromTwoSentencesDemo {
    public string[] UncommonFromSentences(string A, string B) {
        string[] sA = A.Split(' ');
        string[] sB = B.Split(' ');

        Dictionary<string, int> dA = new Dictionary<string, int>();
        Dictionary<string, int> dB = new Dictionary<string, int>();

        foreach (string a in sA) {
            if (dA.ContainsKey(a))
                dA[a]++;
            else
                dA[a] = 1;
        }

        foreach (string b in sB) {
            if (dB.ContainsKey(b))
                dB[b]++;
            else
                dB[b] = 1;
        }

        List<string> ret = new List<string>();

        foreach (string key in dA.Keys) {
            if (dA[key] == 1 && !dB.ContainsKey(key))
                ret.Add(key);
        }
        foreach (string key in dB.Keys) {
            if (dB[key] == 1 && !dA.ContainsKey(key))
                ret.Add(key);
        }

        return ret.ToArray();
    }
}