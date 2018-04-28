//https://leetcode-cn.com/problems/palindrome-number/description/

public class PalindromeNumberDemo {
    public bool IsPalindrome(int x) {
        if (x < 0)
            return false;

        int nOri = x;
        int nPalind = 0;
        while (nOri != 0)
        {
            nPalind = nPalind * 10 + (nOri % 10);
            nOri = nOri / 10;
        }

        return x == nPalind;
    }
}