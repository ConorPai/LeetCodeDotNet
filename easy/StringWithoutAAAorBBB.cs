//https://leetcode-cn.com/problems/string-without-aaa-or-bbb/

using System.Text;

public class StringWithoutAAAorBBBDemo {
    public string StrWithout3a3b(int A, int B) {

        StringBuilder ans = new StringBuilder();

        while (A > 0 || B > 0) {
            bool writeA = false;
            int L = ans.Length;
            char[] s = ans.ToString().ToCharArray();
            if (L >= 2 && s[L-1] == s[L-2]) {
                if (s[L-1] == 'b')
                    writeA = true;
            } else {
                if (A >= B)
                    writeA = true;
            }

            if (writeA) {
                A--;
                ans.Append('a');
            } else {
                B--;
                ans.Append('b');
            }
        }

        return ans.ToString();
    }
}