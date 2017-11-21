//https://leetcode.com/problems/minimum-depth-of-binary-tree/description/

public class MinimumDepthofBinaryTreeDemo {
    public int MinDepth(TreeNode root) {
        
        if (root == null)
            return 0;

        int nLeft = MinDepth(root.left);
        int nRigth = MinDepth(root.right);

        int nResult = 1;
        if (root.left == null && root.right != null)
            nResult += nRigth;
        else if (root.left != null && root.right == null)
            nResult += nLeft;
        else if (root.left != null && root.right != null)
            nResult += nLeft < nRigth ? nLeft : nRigth;
        
        return nResult;
    }
}