//https://leetcode-cn.com/problems/combination-sum/

using System.Collections.Generic;

public class CombinationSumDemo {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        IList<IList<int>> ret = new List<IList<int>>();
        Combinations(ret,new List<int>(), candidates, target, 0);
        return ret;
    }
    private void Combinations(IList<IList<int>> lists, IList<int> templist, int[] nums, int target, int start)
    {
        if (target < 0)
            return;

        if(target == 0)
        {
            lists.Add(new List<int>(templist));
        }
     
        for(int i = start; i < nums.Length; i++)
        {
            templist.Add(nums[i]);
            Combinations(lists, templist, nums, target - nums[i], i);
            templist.RemoveAt(templist.Count - 1);
        }
      
    }
}