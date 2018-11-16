//https://leetcode-cn.com/problems/number-of-1-bits/

public class Numberof1BitsDemo {
    public int HammingWeight(uint n) {
        uint count = 0;
        while(n != 0){
            count += n & 1;
            n = n >> 1;
        }
        return (int)count;
    }
}