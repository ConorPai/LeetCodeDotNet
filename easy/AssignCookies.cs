//https://leetcode-cn.com/problems/assign-cookies/description/

using System.Collections.Generic;

public class AssignCookiesDemo {
    public int FindContentChildren(int[] g, int[] s) {
        List<int> listG = new List<int>(g);
        List<int> listS = new List<int>(s);

        listG.Sort();
        listS.Sort();

        int j = 0;
        for (int i = 0; i < listS.Count && j < listG.Count; i++)
        {
            if (listG[j] <= listS[i])
                j++;
        }
        return j;
    }
}