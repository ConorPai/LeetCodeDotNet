//https://leetcode-cn.com/problems/valid-parentheses/description/

using System.Collections.Generic;

public class ValidParenthesesDemo {
    public bool IsValid(string s) {
        List<char> cs = new List<char>();
        foreach (char c in s.ToCharArray())
        {
            if (cs.Count == 0 || c == '(' || c == '[' || c == '{')
            {
                cs.Add(c);
                continue;
            }

            if (IsValid(cs[cs.Count - 1], c))
                cs.RemoveAt(cs.Count - 1);
            else
                return false;
        }

        return cs.Count == 0;
    }

    private bool IsValid(char a, char b)
    {
        if (a == '(')
            return b == ')';

        if (a == '[')
            return b == ']';

        if (a == '{')
            return b == '}';

        return false;
    }
}