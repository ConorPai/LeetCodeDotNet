//https://leetcode.com/problems/min-stack/description/

using System.Collections.Generic;

public class MinStack {

    private List<int> data = new List<int>();
    /** initialize your data structure here. */
    public MinStack() {
        data.Clear();
    }
    
    public void Push(int x) {

        if (data.Count == 0)
        {
            data.Add(x);
            return;
        }
        
        if (GetMin() > x)
        {
            data.Add(x);
            return;
        }

        int nIndex = 0;
        for (int i = 0; i < data.Count; i++)
        {
            if (data[i] < x)
            {
                nIndex = i;
                break;
            }
        }

        data.Add(0);
        for (int i = data.Count - 1; i > nIndex; i--)
            data[i] = data[i - 1];
        
        data[nIndex] = x;
    }
    
    public void Pop() {
        data.Remove(data[data.Count - 1]);
    }
    
    public int Top() {
        return data[0];
    }
    
    public int GetMin() {
        return data.Count > 0 ? data[data.Count - 1] : 0;
    }
}