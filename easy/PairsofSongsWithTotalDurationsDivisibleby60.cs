//https://leetcode-cn.com/problems/pairs-of-songs-with-total-durations-divisible-by-60/

public class PairsofSongsWithTotalDurationsDivisibleby60Demo {
    public int NumPairsDivisibleBy60(int[] time) {
        int[] nTimes = new int[60];

        foreach (int t in time)
            nTimes[t%60]++;
        
        int nRet = 0;
        for (int i = 1; i < 30; i++)
            nRet += nTimes[i] * nTimes[60 - i];

        nRet += nTimes[0] * (nTimes[0] - 1) / 2;
        nRet += nTimes[30] * (nTimes[30] - 1) / 2;

        return nRet;
    }
}