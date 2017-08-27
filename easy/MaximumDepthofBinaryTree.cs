//https://leetcode.com/problems/maximum-depth-of-binary-tree/description/

public class MaximumDepthofBinaryTreeDemo {
    public int MaxDepth(TreeNode root) {
        
        if (root == null)
            return 0;

        int nLeft = MaxDepth(root.left) + 1;
        int nRight = MaxDepth(root.right) + 1;

        return nLeft > nRight ? nLeft : nRight;
    }
}