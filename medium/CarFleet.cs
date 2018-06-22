//https://leetcode-cn.com/problems/car-fleet/description/

public class CarFleetDemo {
    public int CarFleet(int target, int[] position, int[] speed) {
        
        //初始化double数组，用于存放该里程所在车辆到达终点的时间，默认给-1
        double[] distribution = new double[target + 1];
        for (int i = 0; i < distribution.Length; i++)
            distribution[i] = -1;

        //计算每辆车到达终点的时间，并存在相应里程位置
        for (int i = 0; i < position.Length; i++) {
            distribution[position[i]] = (double) (target - position[i]) / speed[i];
        }

        //根据时间归类，算出车队分组
        int fleets = 0;
        double max = -1;
        for (int i = distribution.Length -1; i >= 0; i--) {
            if (distribution[i] > max) {
                max = distribution[i];
                fleets++;
            }
        }

        return fleets;
    }
}