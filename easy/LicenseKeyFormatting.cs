//https://leetcode-cn.com/problems/license-key-formatting/description/

using System;
using System.Text;

public class LicenseKeyFormattingDemo {
    public string LicenseKeyFormatting(string S, int K) {
        string sTemp = S.ToUpper();
        char[] cTemp = sTemp.ToCharArray();

        int nCount = 0;
        StringBuilder sbRet = new StringBuilder();
        for (int i = cTemp.Length - 1; i >= 0; i--)
        {
            if (cTemp[i] == '-')
                continue;

            if (nCount == K)
            {
                sbRet.Append("-");
                nCount = 0;
            }

            sbRet.Append(cTemp[i]);

            nCount++;
        }

        char[] cRet = sbRet.ToString().ToCharArray();
        Array.Reverse(cRet);
        return new string(cRet);
    }
}