//https://leetcode-cn.com/problems/kth-largest-element-in-a-stream/description/

using System;
using System.Collections.Generic;

public class KthLargest {

    ListNode m_lnData = null;
    int nKey = 0;
    public KthLargest(int k, int[] nums) {
        nKey = k;
        ListNode cur = null;
        Array.Sort(nums);
        Array.Reverse(nums);
        foreach (int n in nums)
        {
            if (m_lnData == null)
            {
                m_lnData = cur = new ListNode(n);
            }
            else
            {
                cur.next = new ListNode(n);
                cur = cur.next;
            }
        }
    }
    
    public int Add(int val) {

        bool bValue = false;
        bool bAdd = false;
        if (m_lnData == null || m_lnData.val < val)
        {
            ListNode node = new ListNode(val);
            node.next = m_lnData;
            m_lnData = node;
            bAdd = true;
        }
        
        ListNode cur = m_lnData;

        int nRet = 0;
        int nIndex = 1;
        while (cur != null)
        {
            if (bValue && bAdd)
                break;
            
            if (nIndex == nKey)
            {
                nRet = cur.val;
                bValue = true;
            }

            if (!bAdd && cur.next != null && cur.next.val < val)
            {
                ListNode next = cur.next;
                cur.next = new ListNode(val);
                cur.next.next = next;

                bAdd = true;
            }
            if (cur.next == null && !bAdd)
            {
                cur.next = new ListNode(val);
                bAdd = true;
            }
            nIndex++;
            cur = cur.next;
        }

        return nRet;
    }
}