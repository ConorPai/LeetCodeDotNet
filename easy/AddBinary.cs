//https://leetcode-cn.com/problems/add-binary/

using System;
using System.Collections.Generic;
using System.Text;

public class AddBinaryDemo {
    public string AddBinary(string a, string b) {
        char[] csA = a.ToCharArray();
        char[] csB = b.ToCharArray();

        int nMaxLength = Math.Max(csA.Length, csB.Length);

        List<int> result = new List<int>();
        bool bAdd = false;
        for (int i = 0; i < nMaxLength; i++)
        {
            char cA = '0';
            if (i < csA.Length)
                cA = csA[csA.Length - 1 - i];

            char cB = '0';
            if (i < csB.Length)
                cB = csB[csB.Length - 1 - i];

            int nResult = (int)cA - 48 + (int)cB - 48;
            if (bAdd)
                nResult++;

            bAdd = nResult >= 2;
            result.Add(nResult % 2);
        }

        if (bAdd)
            result.Add(1);

        StringBuilder sbRet = new StringBuilder();

        for (int i = result.Count - 1; i >= 0; i--)
            sbRet.Append(result[i].ToString());

        return sbRet.ToString();
    }
}