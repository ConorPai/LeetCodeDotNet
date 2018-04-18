
//https://leetcode-cn.com/problems/path-sum/description/

public class PathSumDemo {
    public bool HasPathSum(TreeNode root, int sum) {
        
        if (root == null)
            return false;

        if (root.left == null && root.right == null)
            return root.val == sum;

        if (HasPathSum(root.right, sum - root.val))
            return true;

        return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
    }
}