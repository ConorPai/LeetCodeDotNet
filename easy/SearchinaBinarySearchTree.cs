//https://leetcode-cn.com/problems/search-in-a-binary-search-tree/

public class SearchinaBinarySearchTreeDemo {
    public TreeNode SearchBST(TreeNode root, int val) {
        
        if (root == null)
            return null;

        if (root.val == val)
            return root;

        TreeNode ret = SearchBST(root.left, val);
        if (ret != null)
            return ret;

        return SearchBST(root.right, val);
    }
}