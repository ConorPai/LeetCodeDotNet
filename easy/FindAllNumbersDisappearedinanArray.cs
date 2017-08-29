//https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/description/

using System;
using System.Collections.Generic;

public class FindAllNumbersDisappearedinanArrayDemo {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        
        IList<int> result = new List<int>();
        for( int i=0;i< nums.Length; i++){
            int index = nums[i];
            if(nums[Math.Abs(index)-1] > 0){
                nums[Math.Abs(index)-1]= -nums[Math.Abs(index)-1];
            }
        }
        
        for(int j =1 ;j <= nums.Length ; j++){
            if(nums[j-1] > 0){
                result.Add(j);
            }
        }
        return result;
    }
}