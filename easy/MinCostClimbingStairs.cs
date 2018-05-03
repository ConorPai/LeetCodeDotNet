//https://leetcode-cn.com/problems/min-cost-climbing-stairs/description/

using System;

public class MinCostClimbingStairsDemo {
    public int MinCostClimbingStairs(int[] cost) {
        for (int i = 2; i < cost.Length; i++)
            cost[i] += Math.Min(cost[i - 2], cost[i - 1]);

        return Math.Min(cost[cost.Length - 2], cost[cost.Length - 1]);
    }
}