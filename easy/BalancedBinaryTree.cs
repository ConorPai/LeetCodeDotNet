//https://leetcode-cn.com/problems/balanced-binary-tree/

public class BalancedBinaryTreeDemo {
    public bool IsBalanced(TreeNode root) {
        if(root == null)
            return true;
        int left = height(root.left);
        int right = height(root.right);
             
        if (System.Math.Abs(left - right) <= 1 && IsBalanced(root.left) 
            && IsBalanced(root.right)) { 
            return true; 
        } 
        else return false;
    }
    
    public int height (TreeNode root)
    {
        if(root==null) return 0;
        
        int lHeight = height(root.left);
        int rheight = height(root.right);
        
        return lHeight > rheight ? lHeight + 1 : rheight + 1;
    }
}