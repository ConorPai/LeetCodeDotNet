//https://leetcode-cn.com/problems/minimum-index-sum-of-two-lists/description/

using System;
using System.Collections.Generic;

public class MinimumIndexSumofTwoListsDemo {
    public string[] FindRestaurant(string[] list1, string[] list2) {
        
        Dictionary<string, int> dict1 = new Dictionary<string, int>();
        for (int i = 0; i < list1.Length; i++)
            dict1[list1[i]] = i;

        int min = Int32.MaxValue;
        List<string> ret = new List<string>();
        for (int i = 0; i < list2.Length; i++)
        {
            string s = list2[i];
            if (dict1.ContainsKey(s))
            {
                int nIndex = i + dict1[s];
                if (nIndex < min)
                {
                    ret.Clear();
                    ret.Add(s);
                    dict1.Remove(s);
                    min = nIndex;
                }
                else if (nIndex == min)
                    ret.Add(s);
            }
        }

        return ret.ToArray();
    }
}