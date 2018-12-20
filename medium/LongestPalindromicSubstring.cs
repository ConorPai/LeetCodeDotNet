//https://leetcode-cn.com/problems/longest-palindromic-substring/

using System.Text;

public class LongestPalindromicSubstringDemo {
    public string LongestPalindrome(string s) {
        if (s.Length == 1)
            return s;

        char[] cs = s.ToCharArray();
        if (s.Length == 2)
        {
            if (cs[0] == cs[1])
                return s;
            else
                return s.Substring(0, 1);
        }

        int nMaxStart = 0;
        int nMaxLength = 0;

        for (int i = 0; i < s.Length - 1; i++)
        {
            int nNextIndex = i;
            while (nNextIndex + 1 < s.Length && cs[i] == cs[nNextIndex + 1])
                nNextIndex++;

            int nStart = i;
            int nEnd = nNextIndex;
            if (i != nNextIndex)
                i = nEnd;
            int nStep = 1;

            while (nStart - nStep >= 0 && nEnd + nStep < s.Length)
            {
                if (s[nStart - nStep] != s[nEnd + nStep])
                    break;
            
                nStep++;
            }

            int nLength = nEnd - nStart + 1 + 2 * (nStep - 1); 

            if (nLength > nMaxLength)
            {
                nMaxStart = nStart - nStep + 1;
                nMaxLength = nLength;
            }
        }

        if (nMaxLength == 0)
            return "";

        return s.Substring(nMaxStart, nMaxLength);
    }
}