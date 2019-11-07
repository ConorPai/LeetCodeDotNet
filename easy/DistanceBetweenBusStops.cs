using System;

public class DistanceBetweenBusStopsDemo {
    public int DistanceBetweenBusStops(int[] distance, int start, int destination) {
        if(start == destination)
            return 0;
        if(start > destination)
        {
            int temp = start;
            start = destination;
            destination = temp;
        }

        int n = distance.Length;
        int sum1 = 0;
        int sum2 = 0;
        for(int i = 0; i < start; i++)
            sum2 += distance[i];
        for(int i = destination; i < n; i++)
            sum2 += distance[i];

        for(int i = start; i < destination ; i++)
            sum1+=distance[i];
        return Math.Min(sum1, sum2);
    }
}