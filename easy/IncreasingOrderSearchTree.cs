//https://leetcode-cn.com/problems/increasing-order-search-tree/description/

public class IncreasingOrderSearchTreeDemo {
    public TreeNode IncreasingBST(TreeNode root) {
        
        if (root == null)
            return null;

        TreeNode nLeft = IncreasingBST(root.left);
        TreeNode nRight = IncreasingBST(root.right);

        root.left = null;
        root.right = nRight;

        TreeNode left = nLeft;
        while (left != null && left.right != null)
            left = left.right;

        if (left == null)
            left = root;
        else
        {
            left.left = null;
            left.right = root;
        }
        
        return nLeft == null ? left : nLeft;
    }
}