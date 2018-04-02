//https://leetcode-cn.com/problems/subdomain-visit-count/

using System;
using System.Collections.Generic;

public class SubdomainVisitCountDemo {
    public IList<string> SubdomainVisits(string[] cpdomains) {
        Dictionary<string, int> dicResult = new Dictionary<string, int>();

        foreach (string str in cpdomains)
        {
            string[] strSplitResult = str.Split(' ');
            if (strSplitResult.Length != 2)
                continue;

            int nCP = Convert.ToInt32(strSplitResult[0]);
            string[] strDomains = strSplitResult[1].Split('.');

            string strTotalDomain = "";
            for (int i = strDomains.Length - 1; i >= 0; i--)
            {
                if (string.IsNullOrEmpty(strTotalDomain))
                    strTotalDomain = strDomains[i];
                else
                    strTotalDomain = strDomains[i] + "." + strTotalDomain;

                if (dicResult.ContainsKey(strTotalDomain))
                    dicResult[strTotalDomain] += nCP;
                else
                    dicResult[strTotalDomain] = nCP;
            }
        }

        IList<string> strResult = new List<string>();
        foreach (string key in dicResult.Keys)
            strResult.Add(dicResult[key].ToString() + " " + key);
        
        return strResult;
    }
}