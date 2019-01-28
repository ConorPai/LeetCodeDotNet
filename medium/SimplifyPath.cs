//https://leetcode-cn.com/problems/simplify-path/

using System.Collections.Generic;
using System.Text;

public class SimplifyPathDemo {
    public string SimplifyPath(string path) {
        string[] subPath = path.Split('/');

        Stack<string> spath = new Stack<string>();
        foreach (string s in subPath)
        {
            if (string.IsNullOrEmpty(s))
                continue;

            if (s == ".")
                continue;

            if (s == "..")
            {
                if (spath.Count != 0)
                    spath.Pop();
                continue;
            }

            spath.Push(s);
        }

        string[] oArray = spath.ToArray();
        StringBuilder sbRet = new StringBuilder();

        for(int i = oArray.Length - 1; i >= 0; i--)
            sbRet.Append("/" + oArray[i]);

        return sbRet.Length == 0 ? "/" : sbRet.ToString();
    }
}