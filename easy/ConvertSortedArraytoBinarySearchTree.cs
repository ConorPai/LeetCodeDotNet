//https://leetcode-cn.com/problems/convert-sorted-array-to-binary-search-tree/

using System.Linq;

public class ConvertSortedArraytoBinarySearchTreeDemo {
    public TreeNode SortedArrayToBST(int[] nums) {
        if (nums.Length == 0)
            return null;
        if (nums.Length == 1)
            return new TreeNode(nums[0]);
        
        return new TreeNode(nums[nums.Length / 2])
        {
            left = SortedArrayToBST(nums.Take(nums.Length / 2).ToArray()),
            right = SortedArrayToBST(nums.Skip((nums.Length / 2) + 1).Take(nums.Length).ToArray())
        };
    }
}