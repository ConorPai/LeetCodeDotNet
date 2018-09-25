//https://leetcode-cn.com/problems/spiral-matrix-ii/

public class SpiralMatrix2Demo {
    public int[,] GenerateMatrix(int n) {
        int[,] ret = new int[n,n];

        int top = 0;
        int bottom = n-1;
        int left = 0;
        int right = n-1;
        int max  = n*n;
        int counter = 1;
        while (counter <= max) {
            for (int i = left; i <= right; i++) 
                ret[top, i] = counter++;
            top++;

            for (int i = top; i <= bottom; i++) 
                ret[i, right] = counter++;
            right--;

            for (int i = right; i >= left; i--) 
                ret[bottom, i] = counter++;
            bottom--;

            for (int i = bottom; i >= top; i--) 
                ret[i, left] = counter++;
            left++;
        }

        return ret;
    }
}