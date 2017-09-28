//https://leetcode.com/problems/minimum-absolute-difference-in-bst/discuss/

using System;

public class MinimumAbsoluteDifferenceinBSTDemo {

    int minDiff = int.MaxValue;
    TreeNode prev;
    
    public int GetMinimumDifference(TreeNode root) {
        inorder(root);
        return minDiff;
    }
    
    public void inorder(TreeNode root) {
        if (root == null) return;
        inorder(root.left);
        if (prev != null) minDiff = Math.Min(minDiff, root.val - prev.val);
        prev = root;
        inorder(root.right);
    }
}