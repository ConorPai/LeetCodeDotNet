//https://leetcode-cn.com/problems/add-strings/

using System;

public class AddStringsDemo {
    public string AddStrings(string num1, string num2) {
        int n = Math.Max(num1.Length, num2.Length);
        char[] nums = new char[n + 1];
        int carry = 0;
        int i = num1.Length - 1;
        int j = num2.Length - 1;
        
        for ( int k = n ; k >= 0; k --)
        {
            int digit1 = i >= 0 ? num1[i--] - '0' : 0;
            int digit2 = j >= 0 ? num2[j--] - '0' : 0;
            int sum = digit1 + digit2 + carry;
            nums[k]=(char) ((sum % 10 ) + '0');
            carry = sum / 10;
        }
        
        return nums[0] == '0' ? new string(nums, 1, n) : new string(nums);
    }
}