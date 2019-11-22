//https://leetcode-cn.com/problems/range-sum-of-bst/

public class RangeSumofBSTDemo {

    public int RangeSumBST(TreeNode root, int L, int R) {
        if (root == null)
            return 0;

        int nVal = root.val <= R && root.val >= L ? root.val : 0;

        nVal += RangeSumBST(root.left, L, R);
        nVal += RangeSumBST(root.right, L, R);

        return nVal;
    }
}