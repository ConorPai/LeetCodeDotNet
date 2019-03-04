//https://leetcode-cn.com/problems/sum-of-even-numbers-after-queries/

using System.Collections.Generic;

public class SumofEvenNumbersAfterQueriesDemo {
    public int[] SumEvenAfterQueries(int[] A, int[][] queries) {
        int nTotalSum = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] % 2 == 0)
                nTotalSum += A[i];
        }

        int[] ret = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            int nValue = queries[i][0];
            int nIndex = queries[i][1];

            if (A[nIndex] % 2 == 0)
                nTotalSum -= A[nIndex];

            A[nIndex] += nValue;

            if (A[nIndex] % 2 == 0)
                nTotalSum += A[nIndex];

            ret[i] = nTotalSum;
        }

        return ret;
    }
}