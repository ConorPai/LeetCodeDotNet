//https://leetcode.com/problems/intersection-of-two-arrays-ii/description/

using System.Collections.Generic;

public class IntersectionofTwoArraysIIDemo {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int, int> dicNum1 = new Dictionary<int, int>();
        Dictionary<int, int> dicNum2 = new Dictionary<int, int>();

        for (int i = 0; i < nums1.Length; i++)
        {
            if (dicNum1.ContainsKey(nums1[i]))
                dicNum1[nums1[i]]++;
            else
                dicNum1[nums1[i]] = 1;
        }
        for (int i = 0; i < nums2.Length; i++)
        {
            if (dicNum2.ContainsKey(nums2[i]))
                dicNum2[nums2[i]]++;
            else
                dicNum2[nums2[i]] = 1;
        }

        List<int> res = new List<int>();
        foreach (int key in dicNum1.Keys)
        {
            if (dicNum2.ContainsKey(key))
            {
                int nCount = dicNum1[key] < dicNum2[key] ? dicNum1[key] : dicNum2[key];

                while (nCount > 0)
                {
                    res.Add(key);
                    nCount--;
                }
            }
        }

        return res.ToArray();
    }
}