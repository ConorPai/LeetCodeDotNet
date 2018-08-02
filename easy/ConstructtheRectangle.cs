//https://leetcode.com/problems/construct-the-rectangle/description/

using System;

public class ConstructtheRectangleDemo {
    public int[] ConstructRectangle(int area) {
        
        int w = (int)Math.Sqrt(area);
        
        while (area % w !=0)
            w--;
        
        return new int[] {area / w, w};
    }
}