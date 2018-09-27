//https://leetcode-cn.com/problems/n-ary-tree-preorder-traversal/

using System.Collections.Generic;

public class NaryTreePreorderTraversalDemo {
    public IList<int> Preorder(Node2 root) {
        Stack<Node2> st = new Stack<Node2>();
        IList<int> ret = new List<int>();

        if (root == null)
            return ret;

        st.Push(root);

        while (st.Count != 0)
        {
            Node2 cur = st.Pop();
            ret.Add(cur.val);

            if (cur.children == null)
                continue;

            for (int i = cur.children.Count - 1; i >= 0; i--)
                st.Push(cur.children[i]);
        }

        return ret;
    }
}