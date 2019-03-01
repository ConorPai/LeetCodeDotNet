//https://leetcode-cn.com/problems/available-captures-for-rook/

public class AvailableCapturesforRookDemo {
    public int NumRookCaptures(char[][] board) {
        int nRI = -1;
        int nRJ = -1;
        for (int i = 0; i < board.Length; i++)
        {
            bool bFind = false;
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == 'R')
                {
                    nRI = i;
                    nRJ = j;
                    bFind = true;
                    break;
                }
            }

            if (bFind)
                break;
        }

        if (nRI == -1 || nRJ == -1)
            return -1;

        int nTotalCount = 0;
        for (int i = nRI - 1; i >= 0; i--)
        {
            if (board[i][nRJ] == 'p')
            {
                nTotalCount++;
                break;
            }

            if (board[i][nRJ] == 'B')
                break;
        }

        for (int i = nRJ - 1; i >= 0; i--)
        {
            if (board[nRI][i] == 'p')
            {
                nTotalCount++;
                break;
            }

            if (board[nRI][i] == 'B')
                break;
        }

        for (int i = nRI + 1; i < board.Length; i++)
        {
            if (board[i][nRJ] == 'p')
            {
                nTotalCount++;
                break;
            }

            if (board[i][nRJ] == 'B')
                break;
        }

        for (int i = nRJ + 1; i < board.Length; i++)
        {
            if (board[nRI][i] == 'p')
            {
                nTotalCount++;
                break;
            }

            if (board[nRI][i] == 'B')
                break;
        }

        return nTotalCount;
    }
}