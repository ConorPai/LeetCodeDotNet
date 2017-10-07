//https://leetcode.com/problems/subtree-of-another-tree/description/

public class SubtreeofAnotherTreeDemo {
    public bool IsSubtree(TreeNode s, TreeNode t) {
        if (s == null) return false;
        if (isSame(s, t)) return true;
        return IsSubtree(s.left, t) || IsSubtree(s.right, t);
    }

    private bool isSame(TreeNode s, TreeNode t) {
        if (s == null && t == null) return true;
        if (s == null || t == null) return false;
        
        if (s.val != t.val) return false;
        
        return isSame(s.left, t.left) && isSame(s.right, t.right);
    }
}