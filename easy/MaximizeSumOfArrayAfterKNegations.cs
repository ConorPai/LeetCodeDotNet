//https://leetcode-cn.com/problems/maximize-sum-of-array-after-k-negations/

public class MaximizeSumOfArrayAfterKNegationsDemo {
    public int LargestSumAfterKNegations(int[] A, int K) {
        
        Array.Sort(A);

        for (int i = 0; i < A.Length; i++)
        {
            if (K == 0 || A[i] >= 0)
                break;
            
            A[i] = -A[i];
            K--;
        }

        if (K > 0 && K % 2 == 1)
        {
            Array.Sort(A);
            A[0] = -A[0];
        }

        int nTotal = 0;
        foreach (int a in A)
            nTotal += a;

        return nTotal;
    }
}