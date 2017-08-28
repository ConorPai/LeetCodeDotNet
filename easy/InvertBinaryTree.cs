//https://leetcode.com/problems/invert-binary-tree/description/

public class InvertBinaryTreeDemo {
    public TreeNode InvertTree(TreeNode root) {
        
        if (root == null)
            return null;

        TreeNode nodeTemp = root.right;
        root.right = InvertTree(root.left);
        root.left = InvertTree(nodeTemp);

        return root;
    }
}