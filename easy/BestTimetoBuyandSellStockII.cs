//https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock-ii/description/

public class BestTimetoBuyandSellStockIIDemo {
    public int MaxProfit(int[] prices) {
        if (prices.Length == 0)
            return 0;

        int nMin = prices[0];
        int nMax = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < prices[i - 1])
            {
                nMax += prices[i - 1] - nMin;
                nMin = prices[i];
            }
        }

        nMax += prices[prices.Length - 1] - nMin;
        return nMax;
    }
}