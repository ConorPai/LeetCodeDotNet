//https://leetcode.com/problems/merge-sorted-array/description/

public class MergeSortedArrayDemo {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        
        int n1Index = 0;
        int n1Count = m;
        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                if (n1Index > n1Count - 1)
                {
                    nums1[n1Count] = nums2[i];
                    n1Index++;
                    n1Count++;
                    break;
                }

                if (nums1[n1Index] > nums2[i])
                {
                    for (int j = n1Count; j > n1Index; j--)
                        nums1[j] = nums1[j - 1];

                    nums1[n1Index] = nums2[i];
                    n1Index++;
                    n1Count++;
                    break;
                }

                n1Index++;
            }
        }
    }
}