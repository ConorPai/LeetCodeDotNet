//https://leetcode-cn.com/problems/remove-nth-node-from-end-of-list/

public class RemoveNthNodeFromEndofListDemo {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        //添加一个首点，防止倒数第n个结点为首点
        ListNode preHead = new ListNode(0);
        preHead.next = head;
        ListNode cur = preHead, end = preHead;

        for (int i = 0; i <= n; i++)
            end = end.next;

        while (end != null)
        {
            end = end.next;
            cur = cur.next;
        }

        cur.next = cur.next.next;
        return preHead.next;
    }
}