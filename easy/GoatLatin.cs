//https://leetcode-cn.com/problems/goat-latin/description/

using System.Text;

public class GoatLatinDemo {
    public string ToGoatLatin(string S) {
        string[] splitRet = S.Split(' ');

        StringBuilder sbRet = new StringBuilder();
        StringBuilder sbAs = new StringBuilder();
        sbAs.Append("a");
        foreach (string s in splitRet)
        {
            char cFirst = s.ToCharArray()[0];
            if (cFirst == 'a' || cFirst == 'e' || cFirst == 'i'
            || cFirst == 'o' || cFirst == 'u' || cFirst == 'A'
            || cFirst == 'E' || cFirst == 'I' || cFirst == 'O'
            || cFirst == 'U')
            {
                sbRet.Append(s);
            }
            else
            {
                sbRet.Append(s.Substring(1, s.Length - 1));
                sbRet.Append(cFirst);
            }

            sbRet.Append("ma");
            sbRet.Append(sbAs.ToString());
            sbRet.Append(" ");
            sbAs.Append("a");
        }

        return sbRet.ToString().TrimEnd();
    }
}