//https://leetcode-cn.com/problems/number-of-recent-calls/

using System.Collections.Generic;

public class RecentCounter {

    Queue<int> times = new Queue<int>();
    public RecentCounter() {
        
    }
    
    public int Ping(int t) {
        while (times.Count > 0)
        {
            if (times.Peek() >= t - 3000)
                break;
            times.Dequeue();
        }
        times.Enqueue(t);
        return times.Count;
    }
}