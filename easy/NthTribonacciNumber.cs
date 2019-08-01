//https://leetcode-cn.com/problems/n-th-tribonacci-number/

public class NthTribonacciNumberDemo {
    public int Tribonacci(int n) {
        if (n == 0)
            return 0;
        int a = 1, b = 0, c = 0, d = 0;
        for (int i = 0; i < n; i++)
        {
            d = a + b + c;
            a = b;
            b = c;
            c = d;
        }

        return d;
    }
}