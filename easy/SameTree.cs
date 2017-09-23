//https://leetcode.com/problems/same-tree/description/

public class SameTreeDemo {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        
        if (p == null && q == null)
            return true;
        else if (p != null && q != null)
        {
            if (p.val != q.val)
                return false;

            if (!IsSameTree(p.left, q.left))
                return false;

            if (!IsSameTree(p.right, q.right))
                return false;

            return true;
        }

        return false;
    }
}