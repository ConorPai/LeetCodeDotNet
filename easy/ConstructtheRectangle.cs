//https://leetcode.com/problems/construct-the-rectangle/description/

using System;

public class ConstructtheRectangleDemo {
    public int[] ConstructRectangle(int area) {
        
        double dValue = Math.Sqrt(area);

        if (IsInterge(dValue))
            return new int[] {(int)dValue, (int)dValue};

        int nWidth = (int)dValue;
        while (true)
        {
            if (IsInterge((double)area / (double)nWidth))
                return new int[]{(int)(area / nWidth), nWidth};

            nWidth--;
        }

        return new int[]{};
    }

    public bool IsInterge(double dValue)
    {
        int nValue = (int)dValue;

        if (Math.Abs(dValue - nValue) < 0.0000001)
            return true;
        else
            return false;
    }
}