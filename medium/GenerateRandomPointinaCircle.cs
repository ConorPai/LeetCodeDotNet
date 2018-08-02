//https://leetcode-cn.com/problems/generate-random-point-in-a-circle/description/

using System;

public class GenerateRandomPointinaCircleDemo {

    private double m_dRadius;
    private double m_dXCenter;
    private double m_dYCenter;
	Random rng = new Random();
    public GenerateRandomPointinaCircleDemo(double radius, double x_center, double y_center) {
        m_dRadius = radius;
        m_dXCenter = x_center;
        m_dYCenter = y_center;
    }
    
    public double[] RandPoint() {
        double rx = m_dRadius * Math.Sqrt(rng.NextDouble());
        double tx = 2 * Math.PI * rng.NextDouble();
        return new double[] { m_dXCenter + rx * Math.Cos(tx), m_dYCenter + rx * Math.Sin(tx) };
    }
}