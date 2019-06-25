//https://leetcode-cn.com/problems/height-checker/

public class HeightCheckerDemo {
    public int HeightChecker(int[] heights) {
        int[] arrayHeights = new int[101];
        foreach (int h in heights)
        {
            arrayHeights[h]++;
        }

        int nCount = 0;
        for (int i = 1, j = 0; i < arrayHeights.Length; i++)
        {
            while (arrayHeights[i]-- > 0)
            {
                if (heights[j++] != i)
                    nCount++;
            }
        }

        return nCount;
    }
}