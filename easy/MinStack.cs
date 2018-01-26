//https://leetcode.com/problems/min-stack/description/

using System;
using System.Collections.Generic;

public class ListNodeMin {
    public int val;
    public int min;
    public ListNodeMin next;
    public ListNodeMin(int x, int m, ListNodeMin n) { val = x; min = m; next = n;}
}

public class MinStack {

    private ListNodeMin data = null;
    /** initialize your data structure here. */
    public MinStack() {
    }
    
    public void Push(int x) {
        if (data == null)
            data = new ListNodeMin(x, x, null);
        else
            data = new ListNodeMin(x, Math.Min(data.min, x), data);
    }
    
    public void Pop() {
        if (data == null)
            return;

        data = data.next;
    }
    
    public int Top() {
        return data == null ? 0 : data.val;
    }
    
    public int GetMin() {
        if (data == null)
            return 0;
        
        return data.min;
    }
}