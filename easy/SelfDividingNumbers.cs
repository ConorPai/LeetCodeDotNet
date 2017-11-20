//https://leetcode.com/problems/self-dividing-numbers/description/

using System.Collections.Generic;

public class SelfDividingNumbersDemo {
    public IList<int> SelfDividingNumbers(int left, int right) {
        
        IList<int> ret = new List<int>();

        for (int i = left; i <= right; i++)
        {
            if (IsSelfDividingNumber(i))
                ret.Add(i);
        }
        return ret;
    }

    public bool IsSelfDividingNumber(int num)
    {
        int oriNum = num;

        while (num > 0)
        {
            int r = num % 10;
            if (r == 0)
                return false;

            if (oriNum % r != 0)
                return false;

            num /= 10;
        }

        return true;
    }
}