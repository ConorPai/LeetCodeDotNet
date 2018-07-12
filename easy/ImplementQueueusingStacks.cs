//https://leetcode-cn.com/problems/implement-queue-using-stacks/description/

using System;
using System.Collections;

public class MyQueue {

    Stack m_list = new Stack();

    /** Initialize your data structure here. */
    public MyQueue() {
        
    }
    
    /** Push element x to the back of queue. */
    public void Push(int x) {
        Stack temp = new Stack();
        while (m_list.Count != 0)
            temp.Push(m_list.Pop());
        
        temp.Push(x);

        while (temp.Count != 0)
            m_list.Push(temp.Pop());
    }
    
    /** Removes the element from in front of queue and returns that element. */
    public int Pop() {
        return Convert.ToInt32(m_list.Pop());
    }
    
    /** Get the front element. */
    public int Peek() {
        return Convert.ToInt32(m_list.Peek());
    }
    
    /** Returns whether the queue is empty. */
    public bool Empty() {
        return m_list.Count == 0;
    }
}