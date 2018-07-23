//https://leetcode-cn.com/problems/advantage-shuffle/description/


using System;
using System.Collections.Generic;

public class AdvantageShuffleDemo {
    public int[] AdvantageCount(int[] A, int[] B) {
        Array.Sort(A);
        int[] sB = B.Clone() as int[];
        Array.Sort(sB);

        Dictionary<int, List<int>> lB = new Dictionary<int, List<int>>();
        int iA = 0, iB = 0;
        int cA = A.Length - 1, cB = sB.Length - 1;
        while (iA <= cA && iB <= cB)
        {
            if (A[iA] > sB[iB])
            {
                if (!lB.ContainsKey(sB[iB]))
                    lB[sB[iB]] = new List<int>();

                lB[sB[iB]].Add(A[iA]);

                iA++;
                iB++;
            }
            else
            {
                if (!lB.ContainsKey(sB[cB]))
                    lB[sB[cB]] = new List<int>();
                    
                lB[sB[cB]].Add(A[iA]);
                cB--;
                iA++;
            }
        }

        for (int i = 0; i < B.Length; i++)
        {
            A[i] = lB[B[i]][0];
            lB[B[i]].Remove(A[i]); 
        }

        return A;
    }
}