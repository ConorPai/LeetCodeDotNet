//https://leetcode-cn.com/problems/maximum-binary-tree/description/

public class MaximumBinaryTreeDemo {
    public TreeNode ConstructMaximumBinaryTree(int[] nums) {
        if (nums == null)
            return null;

        return helper(nums, 0, nums.Length - 1);
    }

    private TreeNode helper(int[] nums, int begin, int end)
    {
        if (begin > end)
            return null;

        int nMaxIndex = begin;

        for (int i = nMaxIndex + 1; i <= end; i++)
        {
            if (nums[i] > nums[nMaxIndex])
                nMaxIndex = i;
        }

        TreeNode root = new TreeNode(nums[nMaxIndex]);

        root.left = helper(nums, begin, nMaxIndex - 1);
        root.right = helper(nums, nMaxIndex + 1, end);
        return root;
    }
}