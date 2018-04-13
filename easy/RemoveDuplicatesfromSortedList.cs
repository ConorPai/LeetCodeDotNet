//https://leetcode-cn.com/problems/remove-duplicates-from-sorted-list/description/

public class RemoveDuplicatesfromSortedListDemo {
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode nodeCur = head;
        while (nodeCur != null)
        {
            if (nodeCur.next != null && nodeCur.val == nodeCur.next.val)
            {
                nodeCur.next = nodeCur.next.next;
                continue;
            }
            
            nodeCur = nodeCur.next;
        }

        return head;
    }
}