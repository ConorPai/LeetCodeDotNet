//https://leetcode.com/problems/binary-tree-level-order-traversal-ii/description/

using System.Collections.Generic;

public class BinaryTreeLevelOrderTraversalIIDemo {
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        
        IList<IList<int>> result = new List<IList<int>>();
        if(root==null) return result;
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count>0){
            List<int> list = new List<int>();
            int size = q.Count;
            for(int i=0; i<size; i++){
                TreeNode node = q.Dequeue();
                list.Add(node.val);
                if(node.left!=null) q.Enqueue(node.left);
                if(node.right!=null) q.Enqueue(node.right);
            }
            result.Insert(0, list);
        }
        return result;
    }
}