//https://leetcode-cn.com/problems/score-after-flipping-matrix/description/

using System;

public class ScoreAfterFlippingMatrixDemo {
    public int MatrixScore(int[][] A) {
        
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i][0] == 0)
                reverse(A, i, true);
        }

        for (int i = 1; i < A[0].Length; i++)
        {
            int nCount = 0;
            for (int j = 0; j < A.Length; j++)
            {
                if (A[j][i] == 1)
                    nCount++;
            }

            if (nCount < A.Length - nCount)
                reverse(A, i, false);
        }
        
        int nTotalScore = 0;
        for (int i = 0; i < A.Length; i++)
            nTotalScore += Score(A, i);
        
        return nTotalScore;
    }

    private void reverse(int[][] A, int nIndex, bool bRow)
    {
        int nCount = bRow ? A[nIndex].Length : A.Length;
        for (int i = 0; i < nCount; i++)
        {
            if (bRow)
                A[nIndex][i] = A[nIndex][i] == 0 ? 1 : 0;
            else
                A[i][nIndex] = A[i][nIndex] == 0 ? 1 : 0;
        }
    }

    private int Score(int[][] A, int nIndex)
    {
        int nScore = 0;
        for (int i = 0; i < A[nIndex].Length; i++)
        {
            nScore += A[nIndex][i] << A[nIndex].Length - i - 1;
        }

        return nScore;
    }
}