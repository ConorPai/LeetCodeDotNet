//https://leetcode-cn.com/problems/backspace-string-compare/description/

using System.Text;

public class BackspaceStringCompareDemo {
    public bool BackspaceCompare(string S, string T) {
        
        StringBuilder sbS = new StringBuilder();
        foreach(char c in S.ToCharArray())
        {
            if (c == '#')
            {
                if (sbS.Length != 0)
                    sbS.Remove(sbS.Length - 1, 1);
            }
            else
                sbS.Append(c);
        }

        StringBuilder sbT = new StringBuilder();
        foreach(char c in T.ToCharArray())
        {
            if (c == '#')
            {
                if (sbT.Length != 0)
                    sbT.Remove(sbT.Length - 1, 1);
            }
            else
                sbT.Append(c);
        }

        return sbS.ToString().CompareTo(sbT.ToString()) == 0;
    }
}