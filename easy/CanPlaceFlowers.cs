//https://leetcode.com/problems/can-place-flowers/description/

public class CanPlaceFlowersDemo {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        
        int count = 1;
        int result = 0;
        for(int i = 0; i < flowerbed.Length; i++)
        {
            if(flowerbed[i] == 0)
                count++;
            else
            {
                result += (count-1)/2;
                count = 0;
            }
        }
        if(count != 0)
            result += count/2;

        return result>=n;
    }
}