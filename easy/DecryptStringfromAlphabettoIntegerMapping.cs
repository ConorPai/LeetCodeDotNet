//https://leetcode-cn.com/problems/decrypt-string-from-alphabet-to-integer-mapping/

public class DecryptStringfromAlphabettoIntegerMappingDemo {
    public string FreqAlphabets(string s) {

        char[] cs = s.ToCharArray();

        string sRet = "";
        for (int i = cs.Length - 1; i >= 0; i--) {
            int cur = 0;
            if (cs[i] == '#')
            {
                cur = (int)(cs[i - 2] - '0') * 10 + (int)(cs[i - 1] - '0');
                i -= 2;
            }
            else
                cur = (int)(cs[i] - '0');

            sRet = ((char)(cur - 1 + (int)'a')).ToString() + sRet;
        }

        return sRet;
    }
}