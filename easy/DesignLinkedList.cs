//https://leetcode-cn.com/problems/design-linked-list/

public class MyLinkedList {

    ListNode m_root = null;

    /** Initialize your data structure here. */
    public MyLinkedList() {
        
    }
    
    /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
    public int Get(int index) {

        ListNode cur = m_root;
        for (int i = 0; i < index; i++)
        {
            if (cur == null)
                return -1;

            cur = cur.next;
        }

        return cur == null ? -1 : cur.val;
    }
    
    /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
    public void AddAtHead(int val) {
        ListNode head = new ListNode(val);
        head.next = m_root;
        m_root = head;
    }
    
    /** Append a node of value val to the last element of the linked list. */
    public void AddAtTail(int val) {

        if (m_root == null)
            return;
        
        ListNode cur = m_root;
        while (cur.next != null)
            cur = cur.next;

        cur.next = new ListNode(val);
    }
    
    /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
    public void AddAtIndex(int index, int val) {

        if (index == 0)
        {
            ListNode root = new ListNode(val);
            root.next = m_root;
            m_root = root;
            return;
        }
        
        if (m_root == null)
            return;
        
        ListNode cur = m_root;
        for (int i = 0; i < index - 1; i++)
        {
            if (cur == null)
                return;

            cur = cur.next;
        }
        
        ListNode node = new ListNode(val);
        node.next = cur.next;
        cur.next = node;
    }
    
    /** Delete the index-th node in the linked list, if the index is valid. */
    public void DeleteAtIndex(int index) {
        
        if (m_root == null)
            return;
        
        ListNode cur = m_root;
        for (int i = 0; i < index - 1; i++)
        {
            if (cur == null)
                return;

            cur = cur.next;
        }

        if (cur == null)
            return;
        
        cur.next = cur.next == null ? null : cur.next.next;
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */