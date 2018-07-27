//https://leetcode-cn.com/problems/walking-robot-simulation/description/

using System;
using System.Collections.Generic;

public class WalkingRobotSimulationDemo {
    public int RobotSim(int[] commands, int[][] obstacles) {

        HashSet<string> os = new HashSet<string>();
        foreach (int[] o in obstacles)
            os.Add(o[0] + "," + o[1]);
        
        int[,] dir = new int[,]{{0,1}, {1,0}, {0,-1}, {-1,0}};
        int nForward = 0;
        int nCurX = 0;
        int nCurY = 0;
        int nRes = 0;
        foreach (int n in commands)
        {
            if (n == -1)
                nForward++;
            else if (n == -2)
                nForward--;
            else
            {
                for (int i = 0; i < n; i++)
                {
                    nCurX += dir[nForward,0];
                    nCurY += dir[nForward,1];

                    if (os.Contains(nCurX + "," + nCurY))
                    {
                        nCurX -= dir[nForward,0];
                        nCurY -= dir[nForward,1];
                        break;
                    }
                }

                nRes = Math.Max(nCurX * nCurX + nCurY * nCurY, nRes);
            }

            nForward = nForward < 0 ? 3 : nForward;
            nForward = nForward > 3 ? 0 : nForward;
        }

        return nRes;
    }
}