//https://leetcode-cn.com/problems/baseball-game/description/

using System;
using System.Collections.Generic;

public class BaseballGameDemo {
    public int CalPoints(string[] ops) {
        List<int> scores = new List<int>();
        int nCount = ops.Length;

        for (int i = 0; i < nCount; i++)
        {
            if (ops[i] == "C")
            {
                for (int j = scores.Count - 1; j >= 0; j--)
                {
                    if (scores[j] != 0)
                    {
                        scores[j] = 0;
                        break;
                    }
                }
            }
            else if (ops[i] == "D")
            {
                for (int j = scores.Count - 1; j >= 0; j--)
                {
                    if (scores[j] != 0)
                    {
                        scores.Add(2 * scores[j]);
                        break;
                    }
                }
            }
            else if (ops[i] == "+")
            {
                int nTotal = 0;
                for (int j = scores.Count - 1; j >= 0; j--)
                {
                    if (scores[j] != 0)
                    {
                        if (nTotal == 0)
                            nTotal = scores[j];
                        else
                        {
                            nTotal += scores[j];
                            break;
                        }
                    }
                }
                scores.Add(nTotal);
            }
            else
                scores.Add(Convert.ToInt32(ops[i]));
        }

        int nRet = 0;
        foreach(int i in scores)
            nRet += i;

        return nRet;
    }
}