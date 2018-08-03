//https://leetcode-cn.com/problems/arranging-coins/description/

public class ArrangingCoinsDemo {
    public int ArrangeCoins(int n) {
        
        int level = 1;
        while (true)
        {
            n -= level;
            if (n < 0)
                break;
            level++;
        }

        return level - 1;
    }
}