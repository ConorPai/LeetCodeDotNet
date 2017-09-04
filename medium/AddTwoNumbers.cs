//https://leetcode.com/problems/add-two-numbers/description/

public class AddTwoNumbersDemo {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            
        ListNode curL1 = l1;
        ListNode curL2 = l2;
        
        ListNode retList = null;
        ListNode curRet = null;
        
        bool bAddOne = false;
        while (true)
        {
            if (curL1 == null && curL2 == null)
                break;
            
            if (curRet == null)
            {
                curRet = new ListNode(0);
                curRet.next = null;
                retList = curRet;
            }
            else
            {
                curRet.next = new ListNode(0);
                curRet = curRet.next;
                curRet.next = null;
            }
            
            if (curL1 != null && curL2 != null)
                curRet.val = curL1.val + curL2.val;
            else if (curL1 == null && curL2 != null)
                curRet.val = curL2.val;
            else if (curL1 != null && curL2 == null)
                curRet.val = curL1.val;
            
            if (bAddOne)
            {
                curRet.val += 1;
                bAddOne = false;
            }
            
            if (curRet.val >= 10)
            {
                curRet.val -= 10;
                bAddOne = true;
            }
            
            if (curL1 != null)
                curL1 = curL1.next;
            if (curL2 != null)
                curL2 = curL2.next;
        }
        
        if (bAddOne)
        {
            curRet.next = new ListNode(0);
            curRet = curRet.next;
            curRet.next = null;
            curRet.val = 1;
        }
        
        return retList;
    }
}