//https://leetcode-cn.com/problems/palindrome-linked-list/


using System.Collections.Generic;

public class PalindromeLinkedListDemo {
    public bool IsPalindrome(ListNode head) {
        if (head == null || head.next == null)
            return true;
        
        int nCount = 0;
        ListNode cur = head;

        Stack<int> stack = new Stack<int>();

        while (cur != null)
        {
            stack.Push(cur.val);

            nCount++;
            cur = cur.next;
        }

        cur = head;
        for (int i = 0; i < nCount / 2; i++)
        {
            if (stack.Pop() != cur.val)
                return false;

            cur = cur.next;
        }

        return true;
    }
}