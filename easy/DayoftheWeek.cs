//https://leetcode-cn.com/problems/day-of-the-week/

public class DayoftheWeekDemo {
    public string DayOfTheWeek(int day, int month, int year) {
        string[] weeks = new string[]{"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
        int[] month_days = new int[]{31,28,31,30,31,30,31,31,30,31,30,31}; 
        int sum = 0;
        for(int i = 1971; i < year; i++)
        {
            if((i % 4 ==0 && i % 100 != 0) || (i % 400 == 0))
                sum += 366;
            else
                sum += 365;
        }
        for(int i=0; i<month-1; i++)
        {
            sum += month_days[i];
            if(i == 1 && ((year % 4 ==0 && year % 100 != 0) || (year % 400 == 0)))
                sum += 1;
        }
        sum += day;
        return weeks[(sum + 4) % 7];
    }
}