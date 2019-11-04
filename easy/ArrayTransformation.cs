//https://leetcode-cn.com/problems/array-transformation/

using System;
using System.Collections.Generic;

public class ArrayTransformationDemo {
    public IList<int> TransformArray(int[] arr) {
        
        if (arr.Length < 3)
            return new List<int>(arr);

        int[] arrCopy = new int[arr.Length];
        Array.Copy(arr, arrCopy, arr.Length);
        int nChange = 0;

        do
        {
            nChange = 0;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    arrCopy[i] = arr[i] - 1;
                    nChange++;
                }
                if  (arr[i] < arr[i - 1] && arr[i] < arr[i + 1])
                {
                    arrCopy[i] = arr[i] + 1;
                    nChange++;
                }
            }

            arr = arrCopy;
        } while (nChange > 0);

        return new List<int>(arr);
    }
}