//https://leetcode.com/problems/power-of-two/description/

public class PowerofTwoDemo {
    public bool IsPowerOfTwo(int n) {
        return ((n & (n-1))==0 && n>0);
    }
}