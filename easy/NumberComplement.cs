//https://leetcode.com/problems/number-complement/description/

public class NumberComplementDemo {
    public int FindComplement(int num) {
        int i = 0;
        int j = 0;
        
        while (i < num)
        {
            i += (int)(System.Math.Pow(2, j));
            j++;
        }
        
        return i - num;
    }
}