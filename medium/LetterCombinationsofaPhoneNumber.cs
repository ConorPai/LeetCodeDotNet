//https://leetcode-cn.com/problems/letter-combinations-of-a-phone-number/

using System;
using System.Collections.Generic;
using System.Linq;

public class LetterCombinationsofaPhoneNumberDemo {
    private Dictionary<char, string> mapping = new Dictionary<char, string> {
        {'2', "abc"},
        {'3', "def"},
        {'4', "ghi"},
        {'5', "jkl"},
        {'6', "mno"},
        {'7', "pqrs"},
        {'8', "tuv"},
        {'9', "wxyz"}
    };
    
    public IList<string> LetterCombinations(string digits) {
        if (String.IsNullOrEmpty(digits)) {
            return new List<string>();
        }
        
        if (digits.Length == 1) {
            return mapping[digits[0]].Select(x => x.ToString()).ToList();
        }
        
        return LetterCombinations(digits.Substring(1))
            .SelectMany(x => mapping[digits[0]].Select(y => y + x))
            .ToList();
    }
}