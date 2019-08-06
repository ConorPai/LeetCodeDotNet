//https://leetcode-cn.com/problems/remove-outermost-parentheses/

using System.Collections;
using System.Text;

public class RemoveOutermostParenthesesDemo {
    public string RemoveOuterParentheses(string S) {
        Stack sss = new Stack();
        StringBuilder sb = new StringBuilder();

        foreach (char c in S.ToCharArray())
        {
            if (sss.Count == 0)
            {
                sss.Push(1);
                continue;
            }

            if (c == '(')
                sss.Push(1);
            else
                sss.Pop();

            if (sss.Count != 0)
                sb.Append(c);
        }

        return sb.ToString();
    }
}