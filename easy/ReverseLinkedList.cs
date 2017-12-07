//https://leetcode.com/problems/reverse-linked-list/description/

public class ReverseLinkedListDemo {
    public ListNode ReverseList(ListNode head) {
        
        if (head == null)
            return null;
        
        ListNode nodeNext = head.next;
        head.next = null;
        while (nodeNext != null)
        {
            ListNode temp = nodeNext.next;
            nodeNext.next = head;
            head = nodeNext;
            nodeNext = temp;
        }

        return head;
    }
}