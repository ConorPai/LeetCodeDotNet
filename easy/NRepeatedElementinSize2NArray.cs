//https://leetcode-cn.com/problems/n-repeated-element-in-size-2n-array/

public class NRepeatedElementinSize2NArrayDemo {
    public int RepeatedNTimes(int[] A) {
        int[] times = new int[10001];

        for (int i = 0; i < 10001; i++)
            times[i] = 0;

        foreach (int n in A)
        {
            times[n]++;

            if (times[n] == A.Length / 2)
                return n;
        }

        return 0;
    }
}