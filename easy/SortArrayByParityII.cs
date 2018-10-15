//https://leetcode-cn.com/problems/sort-array-by-parity-ii/

using System.Collections.Generic;

public class SortArrayByParityIIDemo {
    public int[] SortArrayByParityII(int[] A) {

        List<int> evens = new List<int>();
        List<int> odds = new List<int>();

        foreach (int a in A)
        {
            if (a % 2 == 0)
                evens.Add(a);
            else
                odds.Add(a);
        }
        
        for (int i = 0; i < A.Length;)
        {
            A[i] = evens[i++ / 2];
            A[i] = odds[i++ / 2];
        }

        return A;
    }
}