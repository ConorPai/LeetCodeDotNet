//https://leetcode-cn.com/problems/swap-nodes-in-pairs/

public class SwapNodesinPairsDemo {
    public ListNode SwapPairs(ListNode head) {

        ListNode preHead = new ListNode(0);

        preHead.next = head;
        ListNode cur = preHead;

        while (cur != null)
        {
            if (cur.next == null || cur.next.next == null)
                break;
            
            ListNode n1 = cur.next;
            ListNode n2 = n1.next;

            cur.next = n2;
            n1.next = n2.next;
            n2.next = n1;

            cur = cur.next.next;
        }
        
        return preHead.next;
    }
}