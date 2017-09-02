//https://leetcode.com/problems/two-sum-iv-input-is-a-bst/description/

using System;
using System.Collections.Generic;

public class TwoSumIVDemo {

    List<int> existnums = new List<int>();

    public bool FindTarget(TreeNode root, int k) {
        
        if (root == null)
            return false;

        if (existnums.Exists(x => x == root.val))
            return true;

        existnums.Add(k - root.val);

        if (FindTarget(root.left, k))
            return true;

        if (FindTarget(root.right, k))
            return true;
        
        return false;
    }
}