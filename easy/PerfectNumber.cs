//https://leetcode.com/problems/perfect-number/description/

using System;

public class PerfectNumberDemo {
    public bool CheckPerfectNumber(int num) {
        if (num == 1)
            return false;
        
        int sum = 0;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                sum += i + num / i;
        }
        sum++;
        
        return sum == num;
    }
}