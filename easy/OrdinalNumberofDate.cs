//https://leetcode-cn.com/problems/ordinal-number-of-date/

using System;

public class OrdinalNumberofDateDemo {
    public int DayOfYear(string date) {
        int[] dayOfMonth = new int[]{0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        string[] dates = date.Split('-');

        if (Convert.ToInt32(dates[0]) % 4 == 0)
            dayOfMonth[2] += 1;

        int nTotalDay = 0;
        for (int i = 0; i < Convert.ToInt32(dates[1]); i++)
            nTotalDay+= dayOfMonth[i];
        
        nTotalDay += Convert.ToInt32(dates[2]);
        return nTotalDay;
    }
}