//https://leetcode-cn.com/problems/happy-number/description/

using System;
using System.Collections.Generic;

public class HappyNumberDemo {

    private List<int> m_pNums = new List<int>();
    public bool IsHappy(int n) {

        if (n == 1)
            return true;

        if (n == 0)
            return false;

        if (m_pNums.Contains(n))
            return false;
        m_pNums.Add(n);
        
        int nNextNum = 0;
        while (true)
        {
            if (n == 0)
                break;
            nNextNum += (int)Math.Pow(n % 10, 2);
            n = n / 10;
        }
        return IsHappy(nNextNum);
    }
}