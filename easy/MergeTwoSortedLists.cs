//https://leetcode.com/problems/merge-two-sorted-lists/description/

public class MergeTwoSortedListsDemo {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode lResult = null;
        ListNode lCurrent = null;

        while (true)
        {
            int nMinVal = 0;
            if (l1 == null && l2 == null)
                break;
            else if (l1 == null && l2 != null)
            {
                nMinVal = l2.val;
                l2 = l2.next;
            }
            else if (l1 != null && l2 == null)
            {
                nMinVal = l1.val;
                l1 = l1.next;
            }
            else if (l1.val < l2.val)
            {
                nMinVal = l1.val;
                l1 = l1.next;
            }
            else
            {
                nMinVal = l2.val;
                l2 = l2.next;
            }

            ListNode lTmp = new ListNode(nMinVal);

            if (lCurrent == null)
                lCurrent = lTmp;
            else
                lCurrent.next = lTmp;
                
            if (lResult == null)
                lResult = lCurrent;

            lCurrent = lTmp;
        }

        return lResult;
    }
}