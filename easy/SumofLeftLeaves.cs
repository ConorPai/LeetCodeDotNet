//https://leetcode.com/problems/sum-of-left-leaves/description/

public class SumofLeftLeavesDemo {
    public int SumOfLeftLeaves(TreeNode root) {
        
        if (root == null)
            return 0;

        int nLeftValue = 0;
        if (root.left != null && root.left.left == null && root.left.right == null)
            nLeftValue += root.left.val;

        nLeftValue += SumOfLeftLeaves(root.left);
        nLeftValue += SumOfLeftLeaves(root.right);

        return nLeftValue;
    }
}