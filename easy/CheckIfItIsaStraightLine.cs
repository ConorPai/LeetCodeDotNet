//https://leetcode-cn.com/problems/check-if-it-is-a-straight-line/

public class CheckIfItIsaStraightLineDemo {
    public bool CheckStraightLine(int[][] coordinates) {
        
        if (coordinates.Length < 2)
            return false;

        if (coordinates[1][0] == coordinates[0][0])
        {
            for (int i = 2; i < coordinates.Length; i++) {
                if (coordinates[i][0] != coordinates[0][0])
                    return false;
            }

            return true;
        }
        else
        {
            double k = (coordinates[1][1] - coordinates[0][1]) / (coordinates[1][0] - coordinates[0][0]);
            double b = coordinates[0][1] - k * coordinates[0][0];

            for (int i = 2; i < coordinates.Length; i++) {
                if (coordinates[i][1] != (k * coordinates[i][0] + b))
                    return false;
            }

            return true;
        }
    }
}