//https://leetcode.com/problems/add-digits/description/

public class AddDigitsDemo {
    public int AddDigits(int num) {
        
        int nResult = 0;
        while (num >= 10)
        {
            nResult += num % 10;
            num = (int)(num / 10);
        }

        nResult += num;

        if (nResult >= 10)
            return AddDigits(nResult);
        else
            return nResult;
    }
}