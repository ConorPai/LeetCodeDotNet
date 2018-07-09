//https://leetcode-cn.com/problems/transpose-matrix/description/

public class TransposeMatrixDemo {
    public int[][] Transpose(int[][] A) {
        if (A.Length == 0)
            return null;
        
        int nRow = A.Length;
        int nCol = A[0].Length;

        int[][] result = new int[nCol][];
        for (int i = 0; i < nCol; i++)
        {
            int[] row = new int[nRow];
            for (int j = 0; j < nRow; j++)
            {
                row[j] = A[j][i];
            }
            result[i] = row;
        }

        return result;
    }
}