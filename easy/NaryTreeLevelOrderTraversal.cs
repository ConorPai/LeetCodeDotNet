//https://leetcode-cn.com/problems/n-ary-tree-level-order-traversal/

using System.Collections.Generic;

public class NaryTreeLevelOrderTraversalDemo {
    public IList<IList<int>> LevelOrder(Node2 root) {
        IList<IList<int>> result = new List<IList<int>>();
        if (root == null)
            return result;

        result.Add(new List<int>());
        result[0].Add(root.val);

        foreach (Node2 n in root.children)
            LevelOrderLevel(n, 1, result);

        return result;
    }

    private void LevelOrderLevel(Node2 root, int level, IList<IList<int>> result)
    {
        if (root == null)
            return;

        if (level >= result.Count)
            result.Add(new List<int>());

        result[level].Add(root.val);

        foreach (Node2 n in root.children)
            LevelOrderLevel(n, level + 1, result);
    }
}