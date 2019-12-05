//https://leetcode-cn.com/problems/binary-watch/

using System.Collections.Generic;

public class BinaryWatchDemo {
    public IList<string> ReadBinaryWatch(int num)
    {
        var results = new List<string>();

        for (int i = 0; i < 1024; i++)
        {
            int hours = i / 64;
            if (hours >= 12)
            {
                break;
            }

            int minutes = i % 64;
            if (minutes >= 60)
            {
                continue;
            }

            if (OnsCount(i) == num)
            {
                results.Add(string.Format("{0}:{1:00}", hours, minutes));
            }
        }

        return results;
    }

    private int OnsCount(int number)
    {
        int ons = 0;
        while (number > 0)
        {
            ons += number % 2;
            number /= 2;
        }
        return ons;
    }
}