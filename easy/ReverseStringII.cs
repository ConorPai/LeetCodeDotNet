//https://leetcode-cn.com/problems/reverse-string-ii/

using System;

public class ReverseStringIIDemo {
    public string ReverseStr(string s, int k) {
        char[] cs = s.ToCharArray();
        int nLength = cs.Length;
        int i = 0;
        while(i < nLength) {
            int j = Math.Min(i + k - 1, nLength - 1);
            swap(cs, i, j);
            i += 2 * k;
        }
        return new string(cs);
    }
    private void swap(char[] cs, int l, int r) {
        while (l < r) {
            char temp = cs[l];
            cs[l++] = cs[r];
            cs[r--] = temp;
        }
    }
}