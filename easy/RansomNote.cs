//https://leetcode-cn.com/problems/ransom-note/

using System.Collections.Generic;

public class RansomNoteDemo {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char, int> cs = new Dictionary<char, int>();
        foreach (char c in magazine.ToCharArray())
        {
            if (cs.ContainsKey(c))
                cs[c]++;
            else
                cs[c] = 1;
        }

        foreach (char c in ransomNote.ToCharArray())
        {
            if (!cs.ContainsKey(c))
                return false;

            cs[c]--;

            if (cs[c] < 0)
                return false;
        }

        return true;
    }
}