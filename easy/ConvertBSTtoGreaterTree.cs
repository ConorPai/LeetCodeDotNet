//https://leetcode.com/problems/convert-bst-to-greater-tree/description/

public class ConvertBSTtoGreaterTreeDemo {
    public TreeNode convertBST(TreeNode root) {
        if(root == null)
            return null;

        DFS(root, 0);
        return root;
    }
    
    public int DFS(TreeNode root, int preSum){
        if(root.right != null)
            preSum = DFS(root.right, preSum);
        root.val = root.val + preSum;
        return (root.left != null) ? DFS(root.left, root.val) : root.val;
    }
}