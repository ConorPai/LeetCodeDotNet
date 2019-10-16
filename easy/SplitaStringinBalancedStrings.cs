//https://leetcode-cn.com/problems/split-a-string-in-balanced-strings/

using System.Collections;

public class SplitaStringinBalancedStringsDemo {
    public int BalancedStringSplit(string s) {
        
        int nCount = 0;
        int nTotalCount = 0;
        foreach (char c in s.ToCharArray())
        {
            if (c == 'R')
                nCount++;
            else if (c == 'L')
                nCount--;

            if (nCount == 0)
                nTotalCount++;
        }

        return nTotalCount;
    }
}