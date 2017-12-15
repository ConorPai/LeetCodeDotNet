//https://leetcode.com/problems/find-the-difference/description/

public class FindtheDifferenceDemo {
    public char FindTheDifference(string s, string t) {
        int nTotal = 0;
        foreach(char cs in t.ToCharArray())
        {
            nTotal += (int)cs;
        }

        foreach(char cs in s.ToCharArray())
        {
            nTotal -= (int)cs;
        }

        return (char)nTotal;
    }
}