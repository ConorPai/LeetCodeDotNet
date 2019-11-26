//https://leetcode-cn.com/problems/repeated-substring-pattern/

public class RepeatedSubstringPatternDemo {
    public bool RepeatedSubstringPattern(string s) {
        string str = s + s;
	    return str.Substring(1, str.Length - 2).IndexOf(s) != -1;
    }
}