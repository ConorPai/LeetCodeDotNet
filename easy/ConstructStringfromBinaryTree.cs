//https://leetcode.com/problems/construct-string-from-binary-tree/description/

public class ConstructStringfromBinaryTreeDemo {
    public string Tree2str(TreeNode t) {
        
        if (t == null)
            return "";
        
        if (t.left == null && t.right == null)
            return t.val.ToString();
        else if (t.left != null && t.right == null)
            return t.val.ToString() + "(" + Tree2str(t.left) + ")";
        else
            return t.val.ToString() + "(" + Tree2str(t.left) + ")(" + Tree2str(t.right) + ")";
    }
}