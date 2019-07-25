//https://leetcode-cn.com/problems/add-to-array-form-of-integer/

using System;
using System.Collections.Generic;

public class AddtoArrayFormofIntegerDemo {
    public IList<int> AddToArrayForm(int[] A, int K) {
        
        var m = 0;
        var r = new List<int>();
        
        for(var i = A.Length - 1; i >= 0 || K > 0 || m > 0; i--){
            var c = m + (i >= 0 ? A[i] : 0) + K % 10;
            m = c / 10;
            K /= 10;
            r.Insert(0, c % 10);
        }
        
        return r;
    }
}