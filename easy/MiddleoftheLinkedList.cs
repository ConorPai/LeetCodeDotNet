//https://leetcode-cn.com/problems/middle-of-the-linked-list/description/

public class MiddleoftheLinkedListDemo {
    public ListNode MiddleNode(ListNode head) {
        
        int nTotalCount = 0;
        ListNode temp = head;
        while (temp != null)
        {
            nTotalCount++;
            temp = temp.next;
        }

        int nCount = nTotalCount % 2 == 0 ? nTotalCount / 2 : (nTotalCount - 1) / 2;
        int nCurCont = 0;
        while (head != null)
        {
            if (nCount == nCurCont)
                break;

            nCurCont++;
            head = head.next;
        }

        return head;
    }
}