//https://leetcode.com/problems/diameter-of-binary-tree/description/

using System;

public class DiameterofBinaryTreeDemo {
    int max = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        maxDepth(root);
        return max;
    }
    
    private int maxDepth(TreeNode root) {
        if (root == null) return 0;
        
        int left = maxDepth(root.left);
        int right = maxDepth(root.right);
        
        max = Math.Max(max, left + right);
        
        return Math.Max(left, right) + 1;
    }
}