//https://leetcode-cn.com/problems/self-crossing/description/
//Time Out

using System.Collections.Generic;

public class mzPoint {
    public mzPoint(int x, int y)
    {
        m_nx = x;
        m_ny = y;
    }
    public mzPoint Clone()
    {
        mzPoint pt = new mzPoint(m_nx, m_ny);
        return pt;
    }
    public int m_nx;
    public int m_ny;
}

public class SelfCrossingDemo {
    public bool IsSelfCrossing(int[] x) {
        if (x.Length < 4)
            return false;
        
        List<mzPoint> pts = new List<mzPoint>();

        int iCurrentX = 0;
        int iCurrentY = 0;
        mzPoint pt = new mzPoint(iCurrentX, iCurrentY);
        pts.Add(pt.Clone());
        for (int i = 0; i < x.Length; i++)
        {
            int nStepX = 0;
            int nStepY = 0;
            if (i % 4 == 0)
            {
                nStepX = 0;
                nStepY = 1;
            }
            else if (i % 4 == 1)
            {
                nStepX = 1;
                nStepY = 0;
            }
            else if (i % 4 == 2)
            {
                nStepX = 0;
                nStepY = -1;
            }
            else if (i % 4 == 3)
            {
                nStepX = -1;
                nStepY = 0;
            }
            for (int j = 0; j < x[i]; j++)
            {
                mzPoint ptNew = pt.Clone();
                ptNew.m_nx += nStepX * (j + 1);
                ptNew.m_ny += nStepY * (j + 1);

                if (pts.Find((mzPoint p) => p.m_nx == ptNew.m_nx && p.m_ny == ptNew.m_ny) != null)
                    return true;

                pts.Add(ptNew);
            }

            pt.m_nx += nStepX * x[i];
            pt.m_ny += nStepY * x[i];
        }

        return false;
    }
}