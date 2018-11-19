//https://leetcode-cn.com/problems/valid-palindrome/

using System.Collections.Generic;

public class ValidPalindromeDemo {
    public bool IsPalindrome(string s) {
        if (s == null || s == "" || s.Length == 1)
            return true;
        char[] cs = s.ToLower().ToCharArray();

        List<char> ls = new List<char>();
        foreach (char c in cs)
        {
            if (IsLetter(c))
                ls.Add(c);
        }

        for (int i = 0; i < ls.Count / 2; i++)
        {
            if (ls[i] != ls[ls.Count - 1 - i])
                return false;
        }

        return true;
    }

    private bool IsLetter(char c)
    {
        int value = (int)c;
        return (value >= 48 && value <= 57) || (value >= 97 && value <= 122);
    }
}