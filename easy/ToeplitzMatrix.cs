//https://leetcode.com/problems/toeplitz-matrix/description/

public class ToeplitzMatrixDemo {
    public bool IsToeplitzMatrix(int[,] matrix) {
        
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] != matrix[i - 1, j - 1])
                    return false;
            }
        }

        return true;
    }
}