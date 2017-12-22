//https://leetcode.com/problems/second-minimum-node-in-a-binary-tree/description/

using System;

public class SecondMinimumNodeInaBinaryTreeDemo {
    public int FindSecondMinimumValue(TreeNode root) {
        if (root == null)
            return -1;
        if (root.left == null && root.right == null)
            return -1;
        
        int left = root.left.val;
        int right = root.right.val;
        
        if (root.left.val == root.val)
            left = FindSecondMinimumValue(root.left);
        if (root.right.val == root.val)
            right = FindSecondMinimumValue(root.right);
        
        if (left != -1 && right != -1)
            return Math.Min(left, right);
        else if (left != -1)
            return left;
        else
            return right;
    }
}