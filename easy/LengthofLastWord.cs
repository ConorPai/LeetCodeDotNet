//https://leetcode.com/problems/length-of-last-word/description/

class LengthofLastWordDemo {
    public int lengthOfLastWord(string s) {
        s = s.TrimEnd(' ');
        string[] sRes = s.Split(' ');
        return sRes[sRes.Length - 1].Length;
    }
};