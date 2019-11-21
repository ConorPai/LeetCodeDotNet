//https://leetcode-cn.com/problems/longest-palindrome/

public class LongestPalindromeDemo {
    public int LongestPalindrome(string s) {
        HashSet<char> h = new HashSet<char>();
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (h.Contains(s[i]))
            {
                count += 2;
                h.Remove(s[i]);
            }
            else
            {
                h.Add(s[i]);
            }
        }

        return h.Count > 0 ? count + 1 : count;
    }
}