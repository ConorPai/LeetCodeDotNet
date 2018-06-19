//https://leetcode-cn.com/problems/peak-index-in-a-mountain-array/description/

public class PeakIndexinaMountainArrayDemo {
    public int PeakIndexInMountainArray(int[] A) {

        for (int i = 1; i < A.Length; i++)
        {
            if (A[i] < A[i - 1])
                return i - 1;
        }

        return -1;
    }
}