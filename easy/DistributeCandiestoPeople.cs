//https://leetcode-cn.com/problems/distribute-candies-to-people/

public class DistributeCandiestoPeopleDemo {
    public int[] DistributeCandies(int candies, int num_people) {
        int[] nResult = new int[num_people];

        int nCC = 1;
        int nCI = 0;
        while (candies > 0)
        {
            if (nCC >= candies)
            {
                nResult[nCI] += candies;
                break;
            }
            else
                nResult[nCI] += nCC;
            
            candies -= nCC;
            nCC++;
            nCI++;
            if (nCI >= num_people)
                nCI = 0;
        }

        return nResult;
    }
}