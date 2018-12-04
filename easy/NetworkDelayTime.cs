//https://leetcode-cn.com/problems/network-delay-time/comments/

using System;
using System.Collections.Generic;

public class NetworkDelayTimeDemo {

    private Dictionary<int, int> m_nodeTimes = new Dictionary<int, int>();
    public int NetworkDelayTime(int[,] times, int N, int K) {
        
        Dictionary<int, Dictionary<int, int>> dictTimes = new Dictionary<int, Dictionary<int, int>>();
        for (int i = 0; i < times.GetLength(0); i++)
        {
            if (!dictTimes.ContainsKey(times[i, 0]))
                dictTimes[times[i, 0]] = new Dictionary<int, int>();
            
            dictTimes[times[i, 0]][times[i, 1]] = times[i, 2];
        }

        int[] leftNodes = new int[N];
        for (int i = 0; i < N; i++)
        {
            if (i == K - 1)
                leftNodes[i] = 1;
            else
                leftNodes[i] = 0;
        }

        m_nodeTimes[K] = 0;
        NetworkPassTime(dictTimes, 0, K, leftNodes);

        if (m_nodeTimes.Count != N)
            return -1;

        int nMaxTime = int.MinValue;
        foreach (int key in m_nodeTimes.Keys)
            nMaxTime = Math.Max(nMaxTime, m_nodeTimes[key]);

        return nMaxTime;
    }

    private void NetworkPassTime(Dictionary<int, Dictionary<int, int>> dictTimes, int nBaseTime, int K, int[] leftNodes) {
        
        if (!dictTimes.ContainsKey(K))
            return;

        for (int i = 0; i < leftNodes.Length; i++)
        {
            if (leftNodes[i] == 1)
                continue;
            if (!dictTimes[K].ContainsKey(i + 1))
                continue;
            
            int nTime = nBaseTime + dictTimes[K][i + 1];
            if (m_nodeTimes.ContainsKey(i + 1))
                m_nodeTimes[i + 1] = m_nodeTimes[i + 1] < nTime ? m_nodeTimes[i + 1] : nTime;
            else
                m_nodeTimes[i + 1] = nTime;

            leftNodes[i] = 1;
            NetworkPassTime(dictTimes, nTime, i + 1, leftNodes);
            leftNodes[i] = 0;
        }
    }
}