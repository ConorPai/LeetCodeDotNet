//https://leetcode-cn.com/problems/reverse-integer/description/

public class ReverseIntegerDemo {
    public int Reverse(int x) {
        
        int nRet = 0;
        int nNum = 0;
        int nTemp = 0;
        while (x != 0)
        {
            nNum = x % 10;
            nTemp = nRet * 10 + nNum;
            x /= 10;

            //防越界
            if (nTemp / 10 != nRet || nTemp % 10 != nNum)
                return 0;

            nRet = nTemp;
        }

        return nRet;
    }
}