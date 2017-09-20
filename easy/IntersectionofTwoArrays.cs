//https://leetcode.com/problems/intersection-of-two-arrays/description/

using System.Collections.Generic;

public class IntersectionofTwoArraysDemo {
    
    public int[] generalArray(int[] nums) {
        
        List<int> res = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (res.Contains(nums[i]))
                continue;

            res.Add(nums[i]);
        }

        return res.ToArray();
    }
    
    public int[] Intersection(int[] nums1, int[] nums2) {
        
        int[] res1 = generalArray(nums1);
        int[] res2 = generalArray(nums2);

        List<int> res = new List<int>(res1);


        for (int i = 0; i < res2.Length; i++)
        {
            res.Add(res2[i]);
        }

        res.Sort();

        int nCurrent = 0;
        List<int> ret = new List<int>();

        for (int i = 0; i < res.Count; i++)
        {
            int n = res[i];
            if (i == 0)
            {
                nCurrent = n;
                continue;
            }

            if (n == nCurrent)
                ret.Add(n);

            nCurrent = n;
        }

        return ret.ToArray();
    }
}