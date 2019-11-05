//https://leetcode-cn.com/problems/play-with-chips/

public class PlaywithChipsDemo {
    public int MinCostToMoveChips(int[] chips) {
        int count0 = 0;
        int count1 = 0;
        for(int i = 0; i < chips.Length; i++)
        {
            if(chips[i] % 2 == 0)
                count0++;
            else
                count1++;
        }
        return System.Math.Min(count0, count1);
    }
}