//https://leetcode-cn.com/problems/image-smoother/description/

public class ImageSmootherDemo {
    public int[,] ImageSmoother(int[,] M) {
        int[,] ret = new int[M.GetLength(0), M.GetLength(1)];

        for (int i = 0; i < M.GetLength(0); i++)
        {
            for (int j = 0; j < M.GetLength(1); j++)
            {
                int nStartCol = i - 1 >= 0 ? i - 1 : 0;
                int nEndCol = i + 1 < M.GetLength(0) ? i + 1 : M.GetLength(0) - 1;
                int nStartRow = j - 1 >= 0 ? j - 1 : 0;
                int nEndRow = j + 1 < M.GetLength(1) ? j + 1 : M.GetLength(1) - 1;

                int nTotalValue = 0;
                int nTotalCount = 0;
                for (int m = nStartCol; m <= nEndCol; m++)
                {
                    for (int n = nStartRow; n <= nEndRow; n++)
                    {
                        nTotalValue += M[m, n];
                        nTotalCount++;
                    }
                }

                ret[i, j] = nTotalValue / nTotalCount;
            }
        }

        return ret;
    }
}