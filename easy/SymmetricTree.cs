//https://leetcode-cn.com/problems/symmetric-tree/description/

using System.Collections;

public class SymmetricTreeDemo {
    public bool IsSymmetric(TreeNode root) {
        if (root == null)
            return true;

        Stack st = new Stack();
        st.Push(root.left);
        st.Push(root.right);

        while (st.Count != 0)
        {
            TreeNode n1 = st.Pop() as TreeNode;
            TreeNode n2 = st.Pop() as TreeNode;

            if (n1 == null && n2 == null)
                continue;

            if ((n1 != null && n2 == null)
            || (n1 == null && n2 != null))
                return false;

            if (n1.val != n2.val)
                return false;

            st.Push(n1.left);
            st.Push(n2.right);
            st.Push(n1.right);
            st.Push(n2.left);
        }

        return true;
    }
}