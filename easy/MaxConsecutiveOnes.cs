//https://leetcode.com/problems/max-consecutive-ones/description/

public class MaxConsecutiveOnesDemo {
    public int FindMaxConsecutiveOnes(int[] nums) {
        
        int nMaxResult = 0;
        int nCurResult = 0;
        foreach (int i in nums)
        {
            if (i == 0)
            {
                if (nCurResult > nMaxResult)
                    nMaxResult = nCurResult;

                nCurResult = 0;
            }
            else
            {
                nCurResult++;
            }
        }

        if (nCurResult > nMaxResult)
            nMaxResult = nCurResult;

        return nMaxResult;
    }
}