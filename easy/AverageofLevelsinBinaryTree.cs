//https://leetcode.com/problems/average-of-levels-in-binary-tree/description/

using System.Collections.Generic;

public class staticNode
{
    public int nCount;
    public long nTotalValue;

    public staticNode(int count, int value)
    {
        nCount = count;
        nTotalValue = value;
    }
}
public class AverageofLevelsinBinaryTreeDemo {
    public IList<double> AverageOfLevels(TreeNode root) {

        Dictionary<int, staticNode> sNode = new Dictionary<int, staticNode>();
        int nLevel = 0;
        sNode[nLevel] = new staticNode(1, root.val);

        staticTheNode(root.left, nLevel + 1, sNode);
        staticTheNode(root.right, nLevel + 1, sNode);

        IList<double> dResult = new List<double>();
        foreach (int level in sNode.Keys)
        {
            dResult.Add((double)sNode[level].nTotalValue / (double)sNode[level].nCount);
        }
        return dResult;
    }

    public void staticTheNode(TreeNode node, int nLevel, Dictionary<int, staticNode> sNode)
    {
        if (node == null)
            return;
        if (!sNode.ContainsKey(nLevel))
            sNode[nLevel] = new staticNode(0, 0);
        
        sNode[nLevel].nCount++;
        sNode[nLevel].nTotalValue += node.val;

        staticTheNode(node.left, nLevel + 1, sNode);
        staticTheNode(node.right, nLevel + 1, sNode);
    }
}