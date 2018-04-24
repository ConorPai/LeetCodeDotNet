//https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock/description/

using System;

public class BestTimetoBuyandSellStockDemo {
    public int MaxProfit(int[] prices) {
        if (prices.Length == 0)
            return 0;

        int nMin = prices[0];
        int retMax = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < nMin)
                nMin = prices[i];
            else
                retMax = Math.Max(retMax, prices[i] - nMin);
        }

        return retMax;
    }
}