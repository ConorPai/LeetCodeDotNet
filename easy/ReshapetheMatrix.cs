//https://leetcode-cn.com/problems/reshape-the-matrix/description/

public class ReshapetheMatrixDemo {
    public int[,] MatrixReshape(int[,] nums, int r, int c) {
        if (r * c != nums.GetLength(0) * nums.GetLength(1))
            return nums;

        int[,] newNums = new int[r, c];
        int nNewCol = 0;
        int nNewRow = 0;
        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                newNums[nNewRow, nNewCol] = nums[i,j];

                if (nNewCol == c - 1)
                {
                    nNewRow++;
                    nNewCol = 0;
                }
                else
                    nNewCol++;
            }
        }

        return newNums;
    }
}