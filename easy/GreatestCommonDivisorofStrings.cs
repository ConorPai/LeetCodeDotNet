//https://leetcode-cn.com/problems/greatest-common-divisor-of-strings/

public class GreatestCommonDivisorofStringsDemo {
    public string GcdOfStrings(string str1, string str2) {
        if (str1 + str2 != str2 + str1)
            return "";

        int nGCD = GetGcd(str1.Length, str2.Length);
        return str1.Substring(0, nGCD);
    }

    public int GetGcd(int a, int b) {
        if (b == 0) {
            return a;
        }
        return GetGcd(b, a % b);
    }
}