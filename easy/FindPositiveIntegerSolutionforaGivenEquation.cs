//https://leetcode-cn.com/problems/find-positive-integer-solution-for-a-given-equation/
using System.Collections.Generic;

public class CustomFunction {
    public int f(int x, int y)
    {
        return x + y;
    }
};

public class FindPositiveIntegerSolutionforaGivenEquationDemo {
    public IList<IList<int>> FindSolution(CustomFunction customfunction, int z) {
        IList<IList<int>> res = new List<IList<int>>();
        int left = 1;
        int right = 1000;
        while (left <= 1000 && right >= 1) {
            int temp = customfunction.f(left,right);
            if (temp == z) {
                IList<int> list = new List<int>();
                list.Add(left);
                list.Add(right);
                res.Add(list);
                left++;
            } else if (temp > z) {
                right--;
            } else {
                left++;
            }
        }
        return res;
    }
}