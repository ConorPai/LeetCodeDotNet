//https://leetcode-cn.com/problems/partition-array-into-three-parts-with-equal-sum/

public class PartitionArrayIntoThreePartsWithEqualSumDemo {
    public bool CanThreePartsEqualSum(int[] A) {
        int nSum = 0;
        foreach(int a in A)
            nSum += a;

        if (nSum % 3 != 0)
            return false;

        int nAvg = nSum / 3;
        int nTimes = 0;
        int nTotal = 0;
        foreach (int a in A)
        {
            nTotal += a;
            if (nTotal == nAvg)
            {
                nTimes++;
                nTotal = 0;
            }
        }

        return nTimes == 3;
    }
}