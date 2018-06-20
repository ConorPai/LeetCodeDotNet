//https://leetcode-cn.com/problems/exam-room/description/
using System;
using System.Collections.Generic;

public class ExamRoom {

    private SortedSet<int> m_nSeats = new SortedSet<int>();
    private int m_nTotalSeats = 0;
    public ExamRoom(int N) {
        m_nTotalSeats = N;
    }
    
    public int Seat() {

        if (m_nSeats.Count == 0)
        {
            m_nSeats.Add(0);
            return 0;
        }
        
        int nSeatPos = 0;
        int nMaxDis = 0;
        int nLastPos = Int32.MaxValue;

        var revSeats = m_nSeats.Reverse();
        foreach(int n in revSeats)
        {
            if (nLastPos == Int32.MaxValue)
            {
                nMaxDis = m_nTotalSeats - n - 1;
                nSeatPos = m_nTotalSeats - 1;
            }
            else
            {
                int nTotalDis = nLastPos - n - 1;
                int nCurDis = nTotalDis % 2 == 0 ? nTotalDis / 2 : nTotalDis / 2 + 1;
                if (nCurDis >= nMaxDis)
                {
                    nMaxDis = nCurDis;
                    nSeatPos = n + nCurDis;
                }
            }
            
            nLastPos = n;
        }

        if (nLastPos != 0)
        {
            if (nLastPos >= nMaxDis)
            {
                m_nSeats.Add(0);
                return 0;
            }
        }

        m_nSeats.Add(nSeatPos);
        return nSeatPos;
    }
    
    public void Leave(int p) {
        m_nSeats.Remove(p);
    }
}