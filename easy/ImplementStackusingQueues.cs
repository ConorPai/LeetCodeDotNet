//https://leetcode-cn.com/problems/implement-stack-using-queues/description/

using System.Collections.Generic;

public class MyStack {

    /** Initialize your data structure here. */
    Queue<int> m_q = new Queue<int>();
    Queue<int> m_t = new Queue<int>();
    public MyStack() {
        
    }
    
    /** Push element x onto stack. */
    public void Push(int x) {
        m_q.Enqueue(x);
    }
    
    /** Removes the element on top of the stack and returns that element. */
    public int Pop() {
        while (m_q.Count > 1)
            m_t.Enqueue(m_q.Dequeue());

        int nPopValue = m_q.Dequeue();

        while (m_t.Count > 0)
            m_q.Enqueue(m_t.Dequeue());
        
        return nPopValue;
    }
    
    /** Get the top element. */
    public int Top() {
        while (m_q.Count > 1)
            m_t.Enqueue(m_q.Dequeue());

        int nPopValue = m_q.Dequeue();
        m_t.Enqueue(nPopValue);

        while (m_t.Count > 0)
            m_q.Enqueue(m_t.Dequeue());
        
        return nPopValue;
    }
    
    /** Returns whether the stack is empty. */
    public bool Empty() {
        return m_q.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */