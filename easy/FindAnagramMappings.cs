//https://leetcode.com/problems/find-anagram-mappings/description/

using System.Collections.Generic;

public class FindAnagramMappingsDemo {
    public int[] AnagramMappings(int[] A, int[] B) {
        Dictionary<int, List<int>> dictB = new Dictionary<int, List<int>>();

        for (int i = 0; i < B.Length; i++)
        {
            if (dictB.ContainsKey(B[i]))
                dictB[B[i]].Add(i);
            else
                dictB[B[i]] = new List<int>(){i};
        }

        int[] nResult = new int[A.Length];
        for (int i = 0; i < A.Length; i++)
        {
            List<int> lstIndex = dictB[A[i]];
            nResult[i] = lstIndex[0];
            lstIndex.Remove(lstIndex[0]);
        }

        return nResult;
    }
}