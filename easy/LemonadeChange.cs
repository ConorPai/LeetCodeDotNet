//https://leetcode-cn.com/problems/lemonade-change/description/

using System.Collections.Generic;

public class LemonadeChangeDemo {
    public bool LemonadeChange(int[] bills) {
        Dictionary<int, int> statics = new Dictionary<int, int>();
        statics[5] = 0;
        statics[10] = 0;

        foreach(int i in bills)
        {
            if (i == 5)
                statics[5]++;
            else if (i == 10)
            {
                if (statics[5] <= 0)
                    return false;

                statics[10]++;
                statics[5]--;
            }
            else if (i == 20)
            {
                if (statics[10] > 0)
                {
                    if (statics[5] <= 0)
                        return false;

                    statics[10]--;
                    statics[5]--;
                }
                else
                {
                    if (statics[5] < 3)
                        return false;

                    statics[5] -= 3;
                }
            }
            else
                return false;
        }

        return true;
    }
}