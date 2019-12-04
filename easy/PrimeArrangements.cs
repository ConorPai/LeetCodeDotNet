//https://leetcode-cn.com/problems/prime-arrangements/

using System;

public class PrimeArrangementsDemo {
    public int NumPrimeArrangements(int n) {
        bool IsPrime(int num)
            {
                for (int i = 2; i <= num / 2; i++)
                    if (num % i == 0)
                        return false;

                return true;
            }

            int mod = (int)Math.Pow(10, 9) + 7;

            int count = 0;
            for (int i = 2; i <= n; i++)
                if (IsPrime(i))
                    count++;

            long res = 1;
            for (int i = count; i > 0; i--)
            {
                res = (res * i) % mod;
                res %= mod;
            }

            for (int i = n - count; i > 0; i--)
            {

                res = (res * i) % mod;
                res %= mod;
            }

            return (int)res;
    }
}