//https://leetcode-cn.com/problems/n-ary-tree-postorder-traversal/

using System.Collections.Generic;

public class NaryTreePostorderTraversalDemo {
    public IList<int> Postorder(Node2 root) {

        IList<int> ret = new List<int>();
        Postorder(root, ret);
        return ret;
    }

    public void Postorder(Node2 root, IList<int> values)
    {
        if (root == null || root.children == null)
            return;

        foreach (Node2 n in root.children)
            Postorder(n, values);

        values.Add(root.val);
    }
}