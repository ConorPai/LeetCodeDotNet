//https://leetcode.com/problems/binary-number-with-alternating-bits/description/

public class BinaryNumberwithAlternatingBitsDemo {
    public bool HasAlternatingBits(int n) {
        
        n ^= n/2;
        int n2 = n + 1;
        int n3 = n & n2;
        return n3 == 0;
    }
}