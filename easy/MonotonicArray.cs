//https://leetcode-cn.com/problems/monotonic-array/description/

public class MonotonicArrayDemo {
    public bool IsMonotonic(int[] A) {
        int nIn = -2;
        for (int i = 1; i < A.Length; i++)
        {
            if (A[i] == A[i - 1])
                continue;

            if (nIn == -2)
                nIn = A[i] > A[i - 1] ? 1 : -1;
            else
            {
                if (nIn == -1 && A[i] > A[i - 1])
                    return false;
                else if (nIn == 1 && A[i] < A[i - 1])
                    return false;
            }
        }

        return true;
    }
}