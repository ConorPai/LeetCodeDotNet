//https://leetcode-cn.com/problems/sum-of-two-integers/

public class SumofTwoIntegersDemo {
    public int GetSum(int a, int b) {
        if(b==0) return a;
        if(a==0) return b;
        return GetSum(a^b, (a&b) << 1);
    }
}