//https://leetcode-cn.com/problems/intersection-of-two-linked-lists/description/

using System.Collections.Generic;

public class IntersectionofTwoLinkedListsDemo {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        
        ListNode temp = headA;
        int countA = 0;
        while (temp != null)
        {
            countA++;
            temp = temp.next;
        }

        temp = headB;
        int countB = 0;
        while (temp != null)
        {
            countB++;
            temp = temp.next;
        }

        temp = countA < countB ? headA : headB;

        HashSet<ListNode> nodes = new HashSet<ListNode>();

        while (temp != null)
        {
            nodes.Add(temp);
            temp = temp.next;
        }

        temp = countA >= countB ? headA : headB;

        while (temp != null)
        {
            if (nodes.Contains(temp))
                return temp;
            temp = temp.next;
        }

        return null;
    }
}