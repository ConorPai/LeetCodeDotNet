//https://leetcode-cn.com/problems/rectangle-overlap/description/

public class RectangleOverlapDemo {
    public bool IsRectangleOverlap(int[] rec1, int[] rec2) {
        return rec2[0] < rec1[2] && rec1[0] < rec2[2] && rec2[1] < rec1[3] && rec1[1] < rec2[3];
    }
}