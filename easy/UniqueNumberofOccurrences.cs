//https://leetcode-cn.com/problems/unique-number-of-occurrences/

using System;

public class UniqueNumberofOccurrencesDemo {
    public bool UniqueOccurrences(int[] arr) {
        if (arr.Length == 1)
            return true;
        int[] result = new int[2001];
        foreach (int a in arr)
        {
            result[a + 1000]++;
        }

        Array.Sort(result);

        for (int i = 1; i < result.Length; i++)
        {
            if (result[i] != 0 && result[i] == result[i - 1])
                return false;
        }

        return true;
    }
}