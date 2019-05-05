//https://leetcode-cn.com/problems/reverse-bits/

public class ReverseBitsDemo {
    public uint reverseBits(uint n) {
        uint result = 0;

        uint[] arr = new uint[32];
        int index = 0;

        while (n > 0)
        {
            arr[index++] = n % 2;
            n /= 2;
        }

        for (int i = 0; i < arr.Length; i++)
            result = result * 2 + arr[i];

        return result;
    }
}