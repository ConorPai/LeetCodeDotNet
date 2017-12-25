//https://leetcode.com/problems/binary-tree-paths/description/

using System.Collections.Generic;

public class BinaryTreePathsDemo {
    public IList<string> BinaryTreePaths(TreeNode root) {
        IList<string> result = new List<string>();
        AddBinaryTreePath(root, "", result);
        return result;
    }

    private void AddBinaryTreePath(TreeNode node, string path, IList<string> result)
    {
        if (node == null)
            return;
        
        if (node.left == null && node.right == null)
            result.Add(path + node.val.ToString());

        if (node.left != null)
            AddBinaryTreePath(node.left, path + node.val.ToString() + "->", result);

        if (node.right != null)
            AddBinaryTreePath(node.right, path + node.val.ToString() + "->", result);
    }
}