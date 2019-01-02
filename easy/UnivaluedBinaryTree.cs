//https://leetcode-cn.com/problems/univalued-binary-tree/

public class UnivaluedBinaryTreeDemo {
    public bool IsUnivalTree(TreeNode root) {

        if (root == null)
            return true;

        if (root.left != null)
        {
            if (root.val != root.left.val)
                return false;

            if (!IsUnivalTree(root.left))
                return false;
        }

        if (root.right != null)
        {
            if (root.val != root.right.val)
                return false;

            if (!IsUnivalTree(root.right))
                return false;
        }
        
        return true;
    }
}