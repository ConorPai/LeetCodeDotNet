//https://leetcode-cn.com/problems/remove-linked-list-elements/description/

public class RemoveLinkedListElementsDemo {
    public ListNode RemoveElements(ListNode head, int val) {
        if (head == null)
            return null;

        while (head.val == val)
        {
            head = head.next;
            if (head == null)
                return null;
        }
            
        ListNode cur = head;
        while (cur != null)
        {
            if (cur.next != null && cur.next.val == val)
            {
                cur.next = cur.next.next;
                continue;
            }

            cur = cur.next;
        }

        return head;
    }
}