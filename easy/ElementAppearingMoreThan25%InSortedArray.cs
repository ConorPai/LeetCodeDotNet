//https://leetcode-cn.com/problems/element-appearing-more-than-25-in-sorted-array/

public class ElementAppearingMoreThan25InSortedArrayDemo {
    public int FindSpecialInteger(int[] arr) {

        if (arr.Length == 1)
            return arr[0];
        
        int nCurrent = arr[0];
        int nCount = 1;
        
        for (int i = 1; i < arr.Length; i++)
        {
            if (nCurrent == arr[i])
            {
                nCount++;

                if (nCount * 4 > arr.Length)
                    return nCurrent;
            }
            else
            {
                nCurrent = arr[i];
                nCount = 1;
            }
        }

        return -1;
    }
}