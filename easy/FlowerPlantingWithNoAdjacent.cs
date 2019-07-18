//https://leetcode-cn.com/problems/flower-planting-with-no-adjacent/

using System.Collections.Generic;

public class FlowerPlantingWithNoAdjacentDemo {
    public int[] GardenNoAdj(int N, int[][] paths) {
        int[] nRet = new int[N];
        for (int i = 0; i < N; i++)
            nRet[i] = 0;

        if (N == 1)
        {
            nRet[0] = 1;
            return nRet;
        }
        Dictionary<int, List<int>> gPath = new Dictionary<int, List<int>>();

        for (int i = 0; i < paths.Length; i++)
        {
            int p1 = paths[i][0] - 1;
            int p2 = paths[i][1] - 1;

            if (!gPath.ContainsKey(p1))
                gPath[p1] = new List<int>();

            gPath[p1].Add(p2);

            if (!gPath.ContainsKey(p2))
                gPath[p2] = new List<int>();

            gPath[p2].Add(p1);
        }

        for (int i = 0; i < N; i++)
        {
            if (!gPath.ContainsKey(i))
            {
                nRet[i] = 1;
                continue;
            }
            int[] colors = new int[]{0,0,0,0};

            foreach (int item in gPath[i])
            {
                if (nRet[item] > 0)
                    colors[nRet[item] - 1] = 1;
            }

            for (int j = 0; j < 4; j++)
            {
                if (colors[j] == 0)
                {
                    nRet[i] = j + 1;
                    break;
                }
            }
        }

        return nRet;
    }
}