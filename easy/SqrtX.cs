//https://leetcode.com/problems/sqrtx/

public class SqrtXDemo {
    public int MySqrt(int x) {
        if (x < 4)
            return x == 0 ? 0 : 1;

        int res = 2 * MySqrt(x / 4);
        if ((res + 1) * (res + 1) <= x
        && (res + 1) * (res + 1) >= 0)
            return res + 1;

        return res;
    }
}