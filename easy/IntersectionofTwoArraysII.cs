//https://leetcode.com/problems/intersection-of-two-arrays-ii/description/

using System.Collections.Generic;

public class IntersectionofTwoArraysIIDemo {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        List<int> result = new List<int>();
        for(int i = 0; i < nums1.Length; i++)
        {
            if(map.ContainsKey(nums1[i])) map.Add(nums1[i], map[nums1[i]]+1);
            else map.Add(nums1[i], 1);
        }
    
        for(int i = 0; i < nums2.Length; i++)
        {
            if(map.ContainsKey(nums2[i]) && map[nums2[i]] > 0)
            {
                result.Add(nums2[i]);
                map.Add(nums2[i], map[nums2[i]]-1);
            }
        }
    
       int[] r = new int[result.Count];
       for(int i = 0; i < result.Count; i++)
       {
           r[i] = result[i];
       }
    
       return r;
    }
}