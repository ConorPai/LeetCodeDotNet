//https://leetcode-cn.com/problems/leaf-similar-trees/description/

using System.Text;

public class LeafSimilarTreesDemo {
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        
        string s1 = getleaf(root1);
        string s2 = getleaf(root2);

        return s1.CompareTo(s2) == 0;
    }

    private string getleaf(TreeNode node)
    {
        if (node == null)
            return "";

        if (node.left == null && node.right == null)
            return node.val.ToString();

        StringBuilder sb = new StringBuilder();
        sb.Append(getleaf(node.left));
        sb.Append(getleaf(node.right));

        return sb.ToString();
    }
}