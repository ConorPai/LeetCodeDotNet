//https://leetcode-cn.com/problems/maximum-depth-of-n-ary-tree/description/

using System;
using System.Collections.Generic;

public class Node2 {
    public int val;
    public IList<Node2> children;

    public Node2(){}
    public Node2(int _val,IList<Node2> _children) {
        val = _val;
        children = _children;
}

public class MaximumDepthofN-aryTreeDemo {
    public int MaxDepth(Node2 root) {
        
        if (root == null)
            return 0;

        int nMax = 0;

        foreach(Node2 n in root.children)
        {
            nMax = Math.Max(nMax, MaxDepth(n));
        }

        return nMax + 1;
    }
}