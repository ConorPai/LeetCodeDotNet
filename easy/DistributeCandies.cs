//https://leetcode-cn.com/problems/distribute-candies/description/

using System.Collections.Generic;

public class DistributeCandiesDemo {
    public int DistributeCandies(int[] candies) {
        
        Dictionary<int, int> typeCount = new Dictionary<int, int>();

        foreach(int n in candies)
            typeCount[n] = 0;

        if (typeCount.Count > candies.Length / 2)
            return candies.Length / 2;
        else
            return typeCount.Count;
    }
}