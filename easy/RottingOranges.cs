//https://leetcode-cn.com/problems/rotting-oranges/

using System.Collections.Generic;

public class RottingOrangesDemo {
    private int[] dr = new int[]{-1, 0, 1, 0};
    private int[] dc = new int[]{0, -1, 0, 1};
    public int OrangesRotting(int[][] grid) {
        Queue<int> queue = new Queue<int>();
        Dictionary<int, int> depth = new Dictionary<int, int>();

        int R = grid.Length;
        int C = grid[0].Length;

        for (int i = 0; i < R; i++)
            for (int j = 0; j < C; j++)
            {
                if (grid[i][j] == 2)
                {
                    int nCode = i * C + j;
                    queue.Enqueue(nCode);
                    depth[nCode] = 0;
                }
            }

        int nRet = 0;
        while (queue.Count > 0)
        {
            int nCode = queue.Dequeue();
            int r = nCode / C, c = nCode % C;
            for (int i = 0; i < 4; i++)
            {
                int nr = r + dr[i];
                int nc = c + dc[i];
                int code = nr * C + nc;
                if (nr < 0 || nr >= R || nc < 0 || nc >= C || grid[nr][nc] != 1)
                    continue;
                if (depth.ContainsKey(code))
                    continue;

                grid[nr][nc] = 2;
                queue.Enqueue(code);
                depth[code] = depth[nCode] + 1;
                nRet = depth[code];
            }
        }


        for (int i = 0; i < R; i++)
            for (int j = 0; j < C; j++)
                if (grid[i][j] == 1)
                    return -1;
        
        return nRet;
    }
}