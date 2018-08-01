//https://leetcode-cn.com/problems/generate-random-point-in-a-circle/description/

using System;

public class GenerateRandomPointinaCircleDemo {

    private double m_dRadius;
    private double m_dXCenter;
    private double m_dYCenter;

    private double m_dXMin;
    private double m_dXMax;
    public GenerateRandomPointinaCircleDemo(double radius, double x_center, double y_center) {
        m_dRadius = radius / 2;
        m_dXCenter = x_center;
        m_dYCenter = y_center;
        m_dXMin = x_center - m_dRadius;
        m_dXMax = x_center + m_dRadius;
    }
    
    public double[] RandPoint() {
        Random ran = new Random();
        double dRan = ran.NextDouble();
        double dRanX = m_dXMin + dRan * (m_dXMax - m_dXMin);
        double dYLength = Math.Sqrt(m_dRadius * m_dRadius - (m_dXCenter - dRanX) * (m_dXCenter - dRanX));
        dRan = ran.NextDouble();
        double dRanY = m_dYCenter - dYLength + dRan * 2 * dYLength;
        return new double[]{dRanX, dRanY};
    }
}