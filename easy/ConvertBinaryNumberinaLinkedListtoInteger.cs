//https://leetcode-cn.com/problems/convert-binary-number-in-a-linked-list-to-integer/

using System;

public class ConvertBinaryNumberinaLinkedListtoIntegerDemo {
    public int GetDecimalValue(ListNode head) {
        int nRes = 0;
        while (head != null)
        {
            nRes = 2 * nRes + head.val;
            head = head.next;
        }

        return nRes;
    }
}