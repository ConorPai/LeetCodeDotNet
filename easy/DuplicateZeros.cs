//https://leetcode-cn.com/problems/duplicate-zeros/

public class DuplicateZerosDemo {
    public void DuplicateZeros(int[] arr) {
        int nZeroCount = 0;

        bool bLastIsZero = false;
        for (int i = 0; i + nZeroCount < arr.Length - 1; i++)
        {
            bLastIsZero = arr[i] == 0;
            if (arr[i] == 0)
                nZeroCount++;
        }

        for (int i = arr.Length - 1; nZeroCount > 0 && i >= 0; i--)
        {
            arr[i] = arr[i - nZeroCount];
            if (i == arr.Length - 1 && !bLastIsZero)
                continue;
            if (arr[i - nZeroCount] == 0)
            {
                i--;
                nZeroCount--;
                arr[i] = 0;
            }
        }
    }
}