//https://leetcode.com/problems/merge-two-binary-trees/description/

 public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int x) { val = x; }
 }

 public class Merge_Two_Binary_Trees {
    public TreeNode MergeTrees(TreeNode t1, TreeNode t2) {
        
        if (t1 == null && t2 == null)
            return null;

        int nReslutVal = 0;
        if (t1 == null && t2 != null)
            nReslutVal = t2.val;
        else if (t1 != null && t2 == null)
            nReslutVal = t1.val;
        else
            nReslutVal = t1.val + t2.val;

        TreeNode tResult = new TreeNode(nReslutVal);

        tResult.left = MergeTrees(t1 == null ? null : t1.left, t2 == null ? null : t2.left);
        tResult.right = MergeTrees(t1 == null ? null : t1.right, t2 == null ? null : t2.right);

        return tResult;
    }
}