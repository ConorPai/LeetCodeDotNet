//https://leetcode.com/problems/longest-univalue-path/description/

public class LongestUnivaluePathDemo {
    int m_nMaxLen = 0;
    public int LongestUnivaluePath(TreeNode root) {
        
        if (root == null)
            return 0;

        m_nMaxLen = 0;
        GetMaxLength(root, root.val);
        return m_nMaxLen;
    }

    private int GetMaxLength(TreeNode node, int val)
    {
        if (node == null)
            return 0;
        int left = GetMaxLength(node.left, node.val);
        int right = GetMaxLength(node.right, node.val);

        m_nMaxLen = System.Math.Max(m_nMaxLen, left + right);
        if (val == node.val)
            return System.Math.Max(left, right) + 1;
        return 0;
    }
}