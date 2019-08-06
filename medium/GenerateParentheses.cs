//https://leetcode-cn.com/problems/generate-parentheses/

using System.Collections.Generic;

public class GenerateParenthesesDemo {
    public IList<string> GenerateParenthesis(int n) {
        if (n == 0)
        {
            return new List<string>();
        }

        if (n == 1)
        {
            return new List<string>() { { "()" } };
        }

        var nMinus1 = GenerateParenthesis(n - 1);

        var result = new Dictionary<string, bool>();

        foreach (var r in nMinus1)
        {
            for (int i = 0; i < r.Length; i++)
            {
                result[r.Insert(i, "()")] = true;
            }
        }

        return new List<string>(result.Keys);
    }
}