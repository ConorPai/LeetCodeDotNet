//https://leetcode-cn.com/problems/fibonacci-number/

public class FibonacciNumberDemo {
    public int Fib(int N) {
        if (N == 0)
            return 0;

        if (N == 1)
            return 1;
        
        int ff = 0;
        int f = 1;
        for (int i = 2; i < N; i++)
        {
            int cur = f + ff;
            ff = f;
            f = cur;
        }

        return f + ff;
    }
}