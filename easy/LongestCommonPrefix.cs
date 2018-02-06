//https://leetcode.com/problems/longest-common-prefix/description/

using System.Text;

public class LongestCommonPrefixDemo {
    public string LongestCommonPrefix(string[] strs) {

        if (strs.Length == 0)
            return "";

        StringBuilder ret = new StringBuilder();
        char[] c = strs[0].ToCharArray();
        for (int i = 0; i < c.Length; i++)
        {
            bool bExist = true;
            for (int j = 1; j < strs.Length; j++)
            {
                if (i >= strs[j].Length || strs[j].Substring(i, 1).CompareTo(c[i].ToString()) != 0)
                {
                    bExist = false;
                    break;
                }
            }

            if (!bExist)
                break;

            ret.Append(c[i]);
        }

        return ret.ToString();
    }
}