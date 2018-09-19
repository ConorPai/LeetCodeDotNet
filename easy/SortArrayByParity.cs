//https://leetcode-cn.com/problems/sort-array-by-parity/description/

public class SortArrayByParityDemo {
    public int[] SortArrayByParity(int[] A) {
        int[] nRet = new int[A.Length];

        int nEvenIndex = 0;
        int nOddIndex = A.Length - 1;
        foreach (int a in A)
        {
            if (a % 2 == 0)
                nRet[nEvenIndex++] = a;
            else
                nRet[nOddIndex--] = a;
        }

        return nRet;
    }
}