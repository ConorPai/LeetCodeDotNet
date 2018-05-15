//https://leetcode-cn.com/problems/flipping-an-image/description/

public class FlippinganImageDemo {
    public int[][] FlipAndInvertImage(int[][] A) {
        
        for (int i = 0; i < A.Length; i++)
        {
            int nTotalCount = A[i].Length;
            int nCount = (int)((nTotalCount + 1) / 2);
            for (int j = 0; j < nCount; j++)
            {
                int nFlipIndex = nTotalCount - 1 - j;
                if (nFlipIndex == j)
                    A[i][j] = A[i][j] == 0 ? 1 : 0;
                else
                {
                    int nTemp = A[i][nFlipIndex] == 0 ? 1 : 0;
                    A[i][nFlipIndex] = A[i][j] == 0 ? 1 : 0;
                    A[i][j] = nTemp;
                }
            }
        }

        return A;
    }
}