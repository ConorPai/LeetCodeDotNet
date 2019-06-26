//https://leetcode-cn.com/problems/remove-all-adjacent-duplicates-in-string/


using System.Collections.Generic;
using System.Text;

public class RemoveAllAdjacentDuplicatesInStringDemo {
    public string RemoveDuplicates(string S) {
        char[] cS = S.ToCharArray();

        Stack<char> st = new Stack<char>();

        foreach (char c in cS)
        {
            if (st.Count == 0 || st.Peek() != c)
                st.Push(c);
            else
                st.Pop();
        }

        StringBuilder sb = new StringBuilder();
        foreach (char c in st)
        {
            sb.Insert(0, c);
        }

        return sb.ToString();
    }
}