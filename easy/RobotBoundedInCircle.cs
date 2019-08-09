//https://leetcode-cn.com/problems/robot-bounded-in-circle/

public class RobotBoundedInCircleDemo {
    public bool IsRobotBounded(string instructions) {
        char[] cs = instructions.ToCharArray();
        int x = 0, y = 0;
        int xx = 0, yy = 1;
        int temp = 0;
        for (int i = 0; i < cs.Length; i++) {
            char current = cs[i];
            switch(current) {
                case 'L':
                    temp = xx;
                    xx = -yy;
                    yy = temp;
                    break;
                case 'R':
                    temp = xx;
                    xx = yy;
                    yy = -temp;
                    break;
                case 'G':
                    x += xx;
                    y += yy;
                    break;
            }
        }
        
        return (x == 0 && y == 0) || !(xx == 0 && yy == 1);
    }
}