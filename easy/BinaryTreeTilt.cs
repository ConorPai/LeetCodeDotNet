//https://leetcode.com/problems/binary-tree-tilt/description/

using System;

public class BinaryTreeTiltDemo
{
    int tilt = 0;
    public int FindTilt(TreeNode root)
    {
        traverse(root);
        return tilt;
    }
    public int traverse(TreeNode root)
    {
        if (root == null)
            return 0;
        int left = traverse(root.left);
        int right = traverse(root.right);
        tilt += Math.Abs(left - right);
        return left + right + root.val;
    }
}