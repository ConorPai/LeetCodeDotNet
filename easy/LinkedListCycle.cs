//https://leetcode-cn.com/problems/linked-list-cycle/description/

public class LinkedListCycleDemo {
    public bool HasCycle(ListNode head) {
        
        if(head == null || head.next == null)
        {
            return false;
        }
        
        ListNode slow = head;
        ListNode fast = head.next;
        
        while(fast != null && fast.next != null)
        {
            if(slow == fast)
            {
                return true;
            }
            
            slow = slow.next;
            fast = fast.next.next;
        }
        
        return false;
    }
}