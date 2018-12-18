//https://leetcode-cn.com/problems/zigzag-conversion/

using System.Collections.Generic;
using System.Text;

public class ZigZagConversionDemo {
    public string Convert(string s, int numRows) {

        if (numRows == 1)
            return s;

        char[] cs = s.ToCharArray();
        List<StringBuilder> sbChars = new List<StringBuilder>();

        for (int i = 0; i < numRows; i++)
            sbChars.Add(new StringBuilder());

        for (int i = 0; i < cs.Length; i++)
        {
            int value = i % (2 * numRows - 2);
            if (value < numRows)
                sbChars[value].Append(cs[i]);
            else
                sbChars[2 * numRows - 2 - value].Append(cs[i]);
        }

        StringBuilder sbRet = new StringBuilder();
        foreach (StringBuilder sb in sbChars)
            sbRet.Append(sb);
        
        return sbRet.ToString();
    }
}