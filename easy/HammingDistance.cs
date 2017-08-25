//https://leetcode.com/problems/hamming-distance/description/

public class HammingDistanceDemo {
    public int HammingDistance(int x, int y) {
        int xor = x ^ y, count = 0;
        for (int i=0;i<32;i++)
            count += (xor >> i) & 1;
        return count;
    }
}