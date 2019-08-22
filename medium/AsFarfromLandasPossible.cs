//https://leetcode-cn.com/problems/as-far-from-land-as-possible/

using System.Collections.Generic;

public class AsFarfromLandasPossibleDemo {
    private int[] dr = new int[]{-1, 0, 1, 0};
    private int[] dc = new int[]{0, -1, 0, 1};
    public int MaxDistance(int[][] grid) {
        Queue<int> queue = new Queue<int>();

        int R = grid.Length;
        int C = grid[0].Length;
        for (int i = 0; i < R; i++)
        {
            for (int j = 0; j < C; j++)
            {
                if (grid[i][j] == 1)
                    queue.Enqueue(i * C + j);
            }
        }

        if (queue.Count == 0 || queue.Count == R * C)
            return -1;

        int dis = -1;
        while (queue.Count > 0)
        {
            int nCount = queue.Count;
            for (int i = 0; i < nCount; i++)
            {
                int code = queue.Dequeue();
                int nR = code / C;
                int nC = code % C;
                for (int j = 0; j < 4; j++)
                {
                    int nNextR = nR + dr[j];
                    int nNextC = nC + dc[j];
                    if (nNextR < 0 || nNextR >= R || nNextC < 0 || nNextC >= C || grid[nNextR][nNextC] != 0)
                        continue;

                    grid[nNextR][nNextC] = 1;
                    queue.Enqueue(nNextR * C + nNextC);
                }
            }

            dis++;
        }

        return dis;
    }
}